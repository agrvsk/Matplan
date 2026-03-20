using Matplan.Services.Contracts;
using Matplan.Shared.EntityDtos;
using Matplan.Shared.KodtabellDtos;
using Matplan.Shared.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Matplan.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ArtikelController : ControllerBase
{
    private readonly IServiceManager _serviceManager;

    public ArtikelController(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ArtikelDto>>> GetDeviationAsync([FromQuery] ArtikelRequestParams requestParams)
    {
        var pagedResult = await _serviceManager.ArtikelService.GetArtikelListAsync(requestParams);

        Response.Headers.Append("X-Pagination", JsonConvert.SerializeObject(pagedResult.metaData));

        return Ok(pagedResult.items);
    }

}
