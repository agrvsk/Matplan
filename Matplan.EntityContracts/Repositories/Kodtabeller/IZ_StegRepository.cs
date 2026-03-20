using System;
using System.Collections.Generic;
using System.Text;
using Matplan.EntityContracts.Repositories.Shared;
using Matplan.EntityModels.Models;
using Matplan.Shared.Requests;

namespace Matplan.EntityContracts.Repositories.Kodtabeller;

public interface IZ_StegRepository
{
    Task<Z_Steg?> GetZ_StegAsync(byte id, bool trackChanges = false);
    Task<IPagedList<Z_Steg>> GetZ_StegListAsync(KodtabellByteRequestParams requestParams, bool trackChanges = false);
    Task<bool> Z_StegExistAsync(byte id);
    void Insert(Z_Steg Deviation);
    void Update(Z_Steg Deviation);
    void Delete(Z_Steg deviation);

}
