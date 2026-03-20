using System;
using System.Collections.Generic;
using System.Text;
using Matplan.EntityContracts.Repositories.Shared;
using Matplan.EntityModels.Models;
using Matplan.Shared.Requests;

namespace Matplan.EntityContracts.Repositories.Kodtabeller;

public interface IZ_PlandagRepository
{
    Task<Z_Plandag?> GetZ_PlandagAsync(byte id, bool trackChanges = false);
    Task<IPagedList<Z_Plandag>> GetZ_PlandagListAsync(KodtabellByteRequestParams requestParams, bool trackChanges = false);
    Task<bool> Z_PlandagExistAsync(byte id);
    void Insert(Z_Plandag Deviation);
    void Update(Z_Plandag Deviation);
    void Delete(Z_Plandag deviation);

}
