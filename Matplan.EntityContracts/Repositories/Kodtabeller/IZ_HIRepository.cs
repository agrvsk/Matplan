using System;
using System.Collections.Generic;
using System.Text;
using Matplan.EntityContracts.Repositories.Shared;
using Matplan.EntityModels.Models;
using Matplan.Shared.Requests;

namespace Matplan.EntityContracts.Repositories.Kodtabeller;

public interface IZ_HIRepository
{
    Task<Z_HI?> GetZ_HIAsync(string id, bool trackChanges = false);
    Task<IPagedList<Z_HI>> GetZ_HIListAsync(RequestParams requestParams, bool trackChanges = false);
    Task<bool> Z_HIExistAsync(string id);
    void Insert(Z_HI Deviation);
    void Update(Z_HI Deviation);
    void Delete(Z_HI deviation);

}
