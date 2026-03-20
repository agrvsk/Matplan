using System;
using System.Collections.Generic;
using System.Text;
using Matplan.EntityContracts.Repositories.Shared;
using Matplan.EntityModels.Models;
using Matplan.Shared.Requests;

namespace Matplan.EntityContracts.Repositories.Kodtabeller;

public interface IZ_JaRepository
{
    Task<Z_Ja?> GetZ_JaAsync(byte id, bool trackChanges = false);
    Task<IPagedList<Z_Ja>> GetZ_JaListAsync(KodtabellByteRequestParams requestParams, bool trackChanges = false);
    Task<bool> Z_JaExistAsync(byte id);
    void Insert(Z_Ja Deviation);
    void Update(Z_Ja Deviation);
    void Delete(Z_Ja deviation);

}
