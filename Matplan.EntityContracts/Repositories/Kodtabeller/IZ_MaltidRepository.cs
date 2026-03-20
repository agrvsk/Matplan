using System;
using System.Collections.Generic;
using System.Text;
using Matplan.EntityContracts.Repositories.Shared;
using Matplan.EntityModels.Models;
using Matplan.Shared.Requests;

namespace Matplan.EntityContracts.Repositories.Kodtabeller;

public interface IZ_MaltidRepository
{
    Task<Z_Maltid?> GetZ_MaltidAsync(byte id, bool trackChanges = false);
    Task<IPagedList<Z_Maltid>> GetZ_MaltidListAsync(KodtabellByteRequestParams requestParams, bool trackChanges = false);
    Task<bool> Z_MaltidExistAsync(byte id);
    void Insert(Z_Maltid Deviation);
    void Update(Z_Maltid Deviation);
    void Delete(Z_Maltid deviation);

}
