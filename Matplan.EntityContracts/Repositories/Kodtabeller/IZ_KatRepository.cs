using System;
using System.Collections.Generic;
using System.Text;
using Matplan.EntityContracts.Repositories.Shared;
using Matplan.EntityModels.Models;
using Matplan.Shared.Requests;

namespace Matplan.EntityContracts.Repositories.Kodtabeller;

public interface IZ_KatRepository
{
    Task<Z_Kat?> GetZ_KatAsync(string id, bool trackChanges = false);
    Task<IPagedList<Z_Kat>> GetZ_KatListAsync(RequestParams requestParams, bool trackChanges = false);
    Task<bool> Z_KatExistAsync(string id);
    void Insert(Z_Kat Deviation);
    void Update(Z_Kat Deviation);
    void Delete(Z_Kat deviation);

}
