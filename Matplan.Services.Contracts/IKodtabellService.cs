using Matplan.Shared.KodtabellDtos;
using Matplan.Shared.Paginering;
using Matplan.Shared.Requests;

namespace Matplan.Services.Contracts;

public interface IKodtabellService
{
    Task<(IEnumerable<KodtabellByteDto>? items, MetaData? metaData)> GetByteKodtabellAsync(KodtabellByteRequestParams requestParams, bool trackChanges = false);
    Task<(IEnumerable<KodtabellStringDto>? items, MetaData? metaData)> GetStringKodtabellAsync(KodtabellStringRequestParams requestParams, bool trackChanges = false);

}