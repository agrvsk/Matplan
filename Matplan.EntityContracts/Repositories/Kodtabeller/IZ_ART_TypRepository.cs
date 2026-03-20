using System;
using System.Collections.Generic;
using System.Text;
using Matplan.EntityContracts.Repositories.Shared;
using Matplan.EntityModels.Models;
using Matplan.Shared.Requests;

namespace Matplan.EntityContracts.Repositories.Kodtabeller;

public interface IZ_ART_TypRepository
{
    Task<Z_ART_Typ?> GetZ_ART_TypAsync(string id, bool trackChanges = false);
    Task<IPagedList<Z_ART_Typ>> GetZ_ART_TypListAsync(RequestParams requestParams, bool trackChanges = false);
    Task<bool> Z_ART_TypExistAsync(string id);
    void Insert(Z_ART_Typ Deviation);
    void Update(Z_ART_Typ Deviation);
    void Delete(Z_ART_Typ deviation);

}
