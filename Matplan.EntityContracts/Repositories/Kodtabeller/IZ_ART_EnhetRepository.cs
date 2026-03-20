using System;
using System.Collections.Generic;
using System.Text;
using Matplan.EntityContracts.Repositories.Shared;
using Matplan.EntityModels.Models;
using Matplan.Shared.Requests;

namespace Matplan.EntityContracts.Repositories.Kodtabeller;

public interface IZ_ART_EnhetRepository
{
    Task<Z_ART_Enhet?> GetZ_ART_EnhetAsync(string id, bool trackChanges = false);
    Task<IPagedList<Z_ART_Enhet>> GetZ_ART_EnhetListAsync(RequestParams requestParams, bool trackChanges = false);
    Task<bool> Z_ART_EnhetExistAsync(string id);
    void Insert(Z_ART_Enhet Deviation);
    void Update(Z_ART_Enhet Deviation);
    void Delete(Z_ART_Enhet deviation);

}
