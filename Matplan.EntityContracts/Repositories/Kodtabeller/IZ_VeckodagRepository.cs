using Matplan.EntityContracts.Repositories.Shared;
using Matplan.EntityModels.Models;
using Matplan.Shared.Paginering;
using Matplan.Shared.Requests;

namespace Matplan.EntityContracts.Repositories.Kodtabeller;

public interface IZ_VeckodagRepository
{
    Task<Z_Veckodag?> GetZ_VeckodagAsync(byte id, bool trackChanges = false);
    Task<IPagedList<Z_Veckodag>> GetZ_VeckodagListAsync(KodtabellByteRequestParams requestParams, bool trackChanges = false);
    Task<bool> Z_VeckodagExistAsync(byte id);
    void Insert(Z_Veckodag Deviation);
    void Update(Z_Veckodag Deviation);
    void Delete(Z_Veckodag deviation);


}