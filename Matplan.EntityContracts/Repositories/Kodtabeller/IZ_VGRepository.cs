using System;
using System.Collections.Generic;
using System.Text;
using Matplan.EntityContracts.Repositories.Shared;
using Matplan.EntityModels.Models;
using Matplan.Shared.Requests;

namespace Matplan.EntityContracts.Repositories.Kodtabeller;

public interface IZ_VGRepository
{
    Task<Z_VG?> GetZ_VGAsync(string id, bool trackChanges = false);
    Task<IPagedList<Z_VG>> GetZ_VGListAsync(RequestParams requestParams, bool trackChanges = false);
    Task<bool> Z_VGExistAsync(string id);
    void Insert(Z_VG Deviation);
    void Update(Z_VG Deviation);
    void Delete(Z_VG deviation);

}
