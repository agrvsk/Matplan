using System;
using System.Collections.Generic;
using System.Text;
using Matplan.EntityContracts.Repositories.Shared;
using Matplan.EntityModels.Models;
using Matplan.Shared.Requests;

namespace Matplan.EntityContracts.Repositories.Kodtabeller;

public interface IZ_MatrattRepository
{
    Task<Z_Matratt?> GetZ_MatrattAsync(byte id, bool trackChanges = false);
    Task<IPagedList<Z_Matratt>> GetZ_MatrattListAsync(KodtabellByteRequestParams requestParams, bool trackChanges = false);
    Task<bool> Z_MatrattExistAsync(byte id);
    void Insert(Z_Matratt Deviation);
    void Update(Z_Matratt Deviation);
    void Delete(Z_Matratt deviation);

}
