using System.Net;
using System.Text.Json;
using Matplan.Shared.AuthDtos;
using Matplan.Shared.Paginering;
using Microsoft.AspNetCore.Components;

namespace Matplan.Blazor.Services;

public class ServerApiService(IHttpClientFactory httpClientFactory) : IApiServiceServer
{
    private readonly HttpClient httpClient = httpClientFactory.CreateClient("MatplanAPIClient");

    private readonly JsonSerializerOptions _jsonSerializerOptions = new()
    { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

    //public async Task RefreshTokensAsync(string userId)
    //{
    //    var client = httpClientFactory.CreateClient("APIClient");
    //    var response = await client.PostAsJsonAsync("api/token/refresh", new TokenDto(tokens.AccessToken, tokens.RefreshToken));

    //}

    public async Task<PagedResponse<T>?> CallApiGetPagedAsync<T>(string endpoint, CancellationToken ct = default)
    {
        //Console.WriteLine("try");
        //await authReady.WaitAsync();

        //var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"proxy?endpoint={endpoint}");
        //var response = await httpClient.SendAsync(requestMessage, ct);

        var response = await httpClient.GetAsync(endpoint, ct);

        if (response.StatusCode == System.Net.HttpStatusCode.Forbidden
        || response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
        {
            //navigationManager.NavigateTo("AccessDenied");
        }

        //Handle customized errors
        if (response.StatusCode == HttpStatusCode.NotFound)
        {
            var errorJson = await response.Content.ReadAsStringAsync();
            throw new HttpRequestException(errorJson);
        }

        response.EnsureSuccessStatusCode();

        // 1. Läs items från body
        var items = await JsonSerializer.DeserializeAsync<IEnumerable<T>>(
            await response.Content.ReadAsStreamAsync(ct),
            _jsonSerializerOptions,
            ct);

        // 2. Läs metadata från header
        response.Headers.TryGetValues("X-Pagination", out var headerValues);
        var metaJson = headerValues?.FirstOrDefault();

        MetaData? meta = null;
        if (metaJson is not null)
        {
            meta = JsonSerializer.Deserialize<MetaData>(metaJson, _jsonSerializerOptions);
            //meta = JsonConvert.DeserializeObject<MetaData>(metaJson);
        }

        return new PagedResponse<T>
        {
            Items = items ?? [],
            MetaData = meta ?? new MetaData(1,1,1,1)
        };
    }

    public async Task<T?> CallApiGetAsync<T>(string endpoint, CancellationToken ct = default)
    {
        //Console.WriteLine("try");
        //await authReady.WaitAsync();

        //var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"proxy?endpoint={endpoint}");
        //var response = await httpClient.SendAsync(requestMessage, ct);

        var response = await httpClient.GetAsync(endpoint, ct);

        if (response.StatusCode == System.Net.HttpStatusCode.Forbidden
        ||  response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
        {
            //navigationManager.NavigateTo("AccessDenied");
        }

        //Handle customized errors
        if (response.StatusCode == HttpStatusCode.NotFound)
        {
            var errorJson = await response.Content.ReadAsStringAsync();
            throw new HttpRequestException(errorJson);
        }

        response.EnsureSuccessStatusCode();

        var demoDtos = await JsonSerializer.DeserializeAsync<T>(await response.Content.ReadAsStreamAsync(), _jsonSerializerOptions, CancellationToken.None) ?? default;
        return demoDtos;
    }

}

public class PagedResponse<T>
{
    public IEnumerable<T> Items { get; set; } = [];
    public MetaData MetaData { get; set; } = new(1,1,1,1);
}

//public class MetaData
//{
//    public int TotalCount { get; set; }
//    public int PageSize { get; set; }
//    public int CurrentPage { get; set; }
//    public int TotalPages { get; set; }
//    public bool HasNext { get; set; }
//    public bool HasPrevious { get; set; }
//}
