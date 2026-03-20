using System;
using System.Collections.Generic;
using System.Text;
using Matplan.EntityContracts.Repositories.Shared;
using Matplan.EntityModels.Models;
using Matplan.Shared.Requests;

namespace Matplan.EntityContracts.Repositories.Kodtabeller;

public interface IZ_BristViaSMSRepository
{
    Task<Z_BristViaSMS?> GetZ_BristViaSMSAsync(byte id, bool trackChanges = false);
    Task<IPagedList<Z_BristViaSMS>> GetZ_BristViaSMSListAsync(KodtabellByteRequestParams requestParams, bool trackChanges = false);
    Task<bool> Z_BristViaSMSExistAsync(byte id);
    void Insert(Z_BristViaSMS Deviation);
    void Update(Z_BristViaSMS Deviation);
    void Delete(Z_BristViaSMS deviation);

}
