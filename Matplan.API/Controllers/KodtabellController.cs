using System;
using Matplan.Services.Contracts;
using Matplan.Shared.Enums;
using Matplan.Shared.KodtabellDtos;
using Matplan.Shared.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Matplan.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class KodtabellController : ControllerBase
{
    private readonly IServiceManager _serviceManager;

    public KodtabellController(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
    }


    [HttpGet("Byte")]
    public async Task<ActionResult<IEnumerable<KodtabellByteDto>>> GetBytekodtabellAsync([FromQuery] KodtabellByteRequestParams requestParams)
    {
        var pagedResult = await _serviceManager.KodtabellService.GetByteKodtabellAsync(requestParams);

        Response.Headers.Append("X-Pagination", JsonConvert.SerializeObject(pagedResult.metaData));

        return Ok(pagedResult.items);
    }

    [HttpGet("String")]
    public async Task<ActionResult<IEnumerable<KodtabellStringDto>>> GetStringkodtabellAsync([FromQuery] KodtabellStringRequestParams requestParams)
    {
        var pagedResult = await _serviceManager.KodtabellService.GetStringKodtabellAsync(requestParams);

        Response.Headers.Append("X-Pagination", JsonConvert.SerializeObject(pagedResult.metaData));

        return Ok(pagedResult.items);
    }



    [HttpGet("bytekodtabeller")]
    public IActionResult GetByteKodtabeller()
    {
        var list = EnumDropdownHelper.ToDropdownList<ByteKodtabeller>();
        return Ok(list);
    }


}
