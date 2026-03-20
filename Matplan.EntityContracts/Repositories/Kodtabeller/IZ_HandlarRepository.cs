using System;
using System.Collections.Generic;
using System.Text;
using Matplan.EntityContracts.Repositories.Shared;
using Matplan.EntityModels.Models;
using Matplan.Shared.Requests;

namespace Matplan.EntityContracts.Repositories.Kodtabeller;

public interface IZ_HandlarRepository
{
    Task<Z_Handlar?> GetZ_HandlarAsync(byte id, bool trackChanges = false);
    Task<IPagedList<Z_Handlar>> GetZ_HandlarListAsync(KodtabellByteRequestParams requestParams, bool trackChanges = false);
    Task<bool> Z_HandlarExistAsync(byte id);
    void Insert(Z_Handlar Deviation);
    void Update(Z_Handlar Deviation);
    void Delete(Z_Handlar deviation);

}
