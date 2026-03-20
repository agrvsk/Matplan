using System;
using System.Collections.Generic;
using System.Text;
using Matplan.EntityContracts.Repositories.Shared;
using Matplan.EntityModels.Models;
using Matplan.Shared.Requests;

namespace Matplan.EntityContracts.Repositories.Kodtabeller;

public interface IZ_BeredInkopRepository
{
    Task<Z_BeredInkop?> GetZ_BeredInkopAsync(byte id, bool trackChanges = false);
    Task<IPagedList<Z_BeredInkop>> GetZ_BeredInkopListAsync(KodtabellByteRequestParams requestParams, bool trackChanges = false);
    Task<bool> Z_BeredInkopExistAsync(byte id);
    void Insert(Z_BeredInkop Deviation);
    void Update(Z_BeredInkop Deviation);
    void Delete(Z_BeredInkop deviation);

}
