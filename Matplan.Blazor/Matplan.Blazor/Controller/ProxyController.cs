using System.Net;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;
using System.Web;
using Matplan.Blazor.Services;
using Matplan.Shared.Paginering;
using Microsoft.AspNetCore.Mvc;

namespace Matplan.Blazor.Controller;

[IgnoreAntiforgeryToken]
[Route("proxy")]
[ApiController]
public class ProxyController(IHttpClientFactory httpClientFactory, ITokenStorage tokenService) : ControllerBase
{
    private readonly IHttpClientFactory _httpClientFactory = httpClientFactory;
    private readonly ITokenStorage _tokenService = tokenService;

    [HttpGet]
    public async Task<IActionResult> Proxy([FromQuery] string endpoint)
    {
        ArgumentException.ThrowIfNullOrEmpty(endpoint);

        var client = _httpClientFactory.CreateClient("MatplanAPIClient");

        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        //Vissa endpoints kräver inte inloggad user.
        //if (userId == null)
        //    return Unauthorized("No user ID in claims.");

        if (!string.IsNullOrEmpty(userId))
        {
            var accessToken = await _tokenService.GetAccessTokenAsync(userId);
            //if (string.IsNullOrEmpty(accessToken))
            //    return Unauthorized();
            if (!string.IsNullOrEmpty(accessToken))
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
        }


        // Build the target URI
        var queryString = Request.QueryString.Value;
        var targetUriBuilder = new UriBuilder($"{client.BaseAddress}{endpoint}");
        if (!string.IsNullOrEmpty(queryString))
        {
            var queryParams = HttpUtility.ParseQueryString(queryString);
            queryParams.Remove("endpoint");
            targetUriBuilder.Query = queryParams.ToString();
        }

        //Console.WriteLine("Endpoint: " + endpoint + "\tQuery=" + targetUriBuilder.Uri);

        // Prepare the proxied request
        var method = new HttpMethod(Request.Method);
        var requestMessage = new HttpRequestMessage(method, targetUriBuilder.Uri);

        if (method != HttpMethod.Get && Request.ContentLength > 0)
        {
            Request.EnableBuffering();

            var ms = new MemoryStream();
            await Request.Body.CopyToAsync(ms);
            ms.Position = 0;
            Request.Body.Position = 0;

            requestMessage.Content = new StreamContent(ms);
            if (!string.IsNullOrEmpty(Request.ContentType))
            {
                requestMessage.Content.Headers.ContentType =
                    MediaTypeHeaderValue.Parse(Request.ContentType);
            }
        }

        foreach (var header in Request.Headers)
        {
            if (!header.Key.Equals("Host", StringComparison.OrdinalIgnoreCase))
            {
                requestMessage.Headers.TryAddWithoutValidation(header.Key, header.Value.ToArray());
            }
        }

        Console.WriteLine($"Proxying to: {targetUriBuilder.Uri}");

        var response = await client.SendAsync(requestMessage);

        // Handle errors first
        if (!response.IsSuccessStatusCode)
        {
            var errorJson = await response.Content.ReadAsStringAsync();
            try
            {
                var problem = JsonSerializer.Deserialize<ProblemDetails>(
                    errorJson,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                if (problem != null)
                {
                    Console.WriteLine($"Error Title: {problem?.Title}");
                    Console.WriteLine((int)response.StatusCode);

                    if (response.StatusCode == HttpStatusCode.NotFound)
                        return StatusCode((int)response.StatusCode, problem?.Detail);

                    if (response.StatusCode == HttpStatusCode.BadRequest)
                        return StatusCode((int)response.StatusCode, errorJson);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error parsing ProblemDetails: {ex.Message}");
            }

            return StatusCode((int)response.StatusCode, errorJson);
        }
        
        response.EnsureSuccessStatusCode();
        // Success case — read raw bytes

        // 1. Läs metadata från header
        response.Headers.TryGetValues("X-Pagination", out var paginationValues);
        var metaJson = paginationValues?.FirstOrDefault();

        MetaData? meta = null;
        if (metaJson != null)
            meta = JsonSerializer.Deserialize<MetaData>(metaJson);

        // 2. Läs body (items)
        var json = await response.Content.ReadAsStringAsync();
        // Läs items
        var items = JsonSerializer.Deserialize<JsonElement>(json);

        //Fil?
        //var contentBytes = await response.Content.ReadAsByteArrayAsync();
        //var contentType = response.Content.Headers.ContentType?.ToString() ?? "application/octet-stream";

        // Bygg ett riktigt objekt
        var result = new
        {
            items,
            metaData = meta
        };
        return new JsonResult(result);



        //// Om ingen pagination → returnera JSON direkt
        //if (metaJson == null)
        //    return Content(json, "application/json");

        //// Bygg ett nytt JSON-objekt som klienten kan deserialisera
        //var combined = $@"{{
        //""items"": {json},
        //""metaData"": {metaJson}
        //}}";

        //return Content(combined, "application/json");





        // Optional: try to get filename from Content-Disposition
        //var fileName = response.Content.Headers.ContentDisposition?.FileNameStar
        //               ?? response.Content.Headers.ContentDisposition?.FileName;

        //if (!string.IsNullOrEmpty(fileName))
        //{
        //    return File(contentBytes, contentType, fileName);
        //}

        //return File(contentBytes, contentType);
    }
}