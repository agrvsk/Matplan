using Matplan.Shared.EntityDtos;
using Matplan.Shared.Paginering;
using Matplan.Shared.Requests;

namespace Matplan.Services.Contracts;

public interface IArtikelService
{
    Task<(IEnumerable<ArtikelDto>? items, MetaData? metaData)> GetArtikelListAsync(ArtikelRequestParams requestParams, bool trackChanges = false);

}