using System;
using System.Collections.Generic;
using System.Text;
using Matplan.EntityContracts.Repositories.Shared;
using Matplan.EntityModels.Models;
using Matplan.Shared.Requests;

namespace Matplan.EntityContracts.Repositories.Kodtabeller;

public interface IZ_DatumRepository
{
    Task<Z_Datum?> GetZ_DatumAsync(DateTime id, bool trackChanges = false);
    Task<IPagedList<Z_Datum>> GetZ_DatumListAsync(RequestParams requestParams, bool trackChanges = false);
    Task<bool> Z_DatumExistAsync(DateTime id);
    void Insert(Z_Datum Deviation);
    void Update(Z_Datum Deviation);
    void Delete(Z_Datum deviation);

}
