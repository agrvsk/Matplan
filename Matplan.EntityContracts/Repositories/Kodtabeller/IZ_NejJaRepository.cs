using System;
using System.Collections.Generic;
using System.Text;
using Matplan.EntityContracts.Repositories.Shared;
using Matplan.EntityModels.Models;
using Matplan.Shared.Requests;

namespace Matplan.EntityContracts.Repositories.Kodtabeller;

public interface IZ_NejJaRepository
{
    Task<Z_NejJa?> GetZ_NejJaAsync(byte id, bool trackChanges = false);
    Task<IPagedList<Z_NejJa>> GetZ_NejJaListAsync(KodtabellByteRequestParams requestParams, bool trackChanges = false);
    Task<bool> Z_NejJaExistAsync(byte id);
    void Insert(Z_NejJa Deviation);
    void Update(Z_NejJa Deviation);
    void Delete(Z_NejJa deviation);

}
