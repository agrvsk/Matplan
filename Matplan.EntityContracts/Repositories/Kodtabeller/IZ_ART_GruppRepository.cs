using System;
using System.Collections.Generic;
using System.Text;
using Matplan.EntityContracts.Repositories.Shared;
using Matplan.EntityModels.Models;
using Matplan.Shared.Requests;

namespace Matplan.EntityContracts.Repositories.Kodtabeller;

public interface IZ_ART_GruppRepository
{
    Task<Z_ART_Grupp?> GetZ_ART_GruppAsync(string id, bool trackChanges = false);
    Task<IPagedList<Z_ART_Grupp>> GetZ_ART_GruppListAsync(RequestParams requestParams, bool trackChanges = false);
    Task<bool> Z_ART_GruppExistAsync(string id);
    void Insert(Z_ART_Grupp Deviation);
    void Update(Z_ART_Grupp Deviation);
    void Delete(Z_ART_Grupp deviation);

}
