using System;
using System.Collections.Generic;
using System.Text;
using Matplan.EntityContracts.Repositories.Shared;
using Matplan.EntityModels.Models;
using Matplan.Shared.Requests;

namespace Matplan.EntityContracts.Repositories.Kodtabeller;

public interface IZ_ART_RecEnhRepository
{
    Task<Z_ART_RecEnh?> GetZ_ART_RecEnhAsync(byte id, bool trackChanges = false);
    Task<IPagedList<Z_ART_RecEnh>> GetZ_ART_RecEnhListAsync(KodtabellByteRequestParams requestParams, bool trackChanges = false);
    Task<bool> Z_ART_RecEnhExistAsync(byte id);
    void Insert(Z_ART_RecEnh Deviation);
    void Update(Z_ART_RecEnh Deviation);
    void Delete(Z_ART_RecEnh deviation);

}
