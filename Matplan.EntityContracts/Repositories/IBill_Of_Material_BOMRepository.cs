using Matplan.EntityContracts.Repositories.Shared;
using Matplan.EntityModels.Models;
using Matplan.Shared.Requests;

namespace Matplan.EntityContracts.Repositories;

public interface IBill_Of_Material_BOMRepository
{
    Task<Bill_Of_Material_BOM?> GetBill_Of_Material_BOMAsync(long ArtikelNr, long OpNr, long OpOrdNr, bool trackChanges = false);
    Task<IPagedList<Bill_Of_Material_BOM>> GetBill_Of_Material_BOMListAsync(BomRequestParams requestParams, bool trackChanges = false);
    Task<bool> Bill_Of_Material_BOMExistAsync(long ArtikelNr, long OpNr, long OpOrdNr);

}