using System;
using System.Collections.Generic;
using System.Text;
using Matplan.EntityContracts.Repositories.Shared;
using Matplan.EntityModels.Models;
using Matplan.Shared.Requests;

namespace Matplan.EntityContracts.Repositories.Kodtabeller;

public interface IZ_ART_LagringRepository
{
    Task<Z_ART_Lagring?> GetZ_ART_LagringAsync(string id, bool trackChanges = false);
    Task<IPagedList<Z_ART_Lagring>> GetZ_ART_LagringListAsync(RequestParams requestParams, bool trackChanges = false);
    Task<bool> Z_ART_LagringExistAsync(string id);
    void Insert(Z_ART_Lagring Deviation);
    void Update(Z_ART_Lagring Deviation);
    void Delete(Z_ART_Lagring deviation);

}
