using System;
using System.Collections.Generic;
using System.Text;
using Matplan.EntityContracts.Repositories.Kodtabeller;
using Matplan.EntityContracts.Repositories.Shared;
using Matplan.EntityModels.Models;
using Matplan.Infrastructure.Data;
using Matplan.Infrastructure.Repositories.Shared;
using Matplan.Shared.Requests;
using Microsoft.EntityFrameworkCore;

namespace Matplan.Infrastructure.Repositories.Kodtabeller;

public class Z_StegRepository : RepositoryBase<Z_Steg>, IZ_StegRepository
{
    public Z_StegRepository(MatplanDBContext context) : base(context)
    {
    }

    public async Task<Z_Steg?> GetZ_StegAsync(byte id, bool trackChanges = false)
    {
        var retur = await FindByCondition(c => c.Storedpfu.Equals(id), trackChanges).FirstOrDefaultAsync();
        //        if (retur == null) throw new Z_VeckodagNotFoundException(id);
        return retur;
    }


    public async Task<IPagedList<Z_Steg>> GetZ_StegListAsync(KodtabellByteRequestParams requestParams, bool trackChanges = false)
    {
        var query = FindAll(trackChanges);
        query = query.OrderBy(o => o.Storedpfu);

        var retur = await PagedList<Z_Steg>.CreateAsync(query, requestParams.PageNumber, requestParams.PageSize);
        return (IPagedList<Z_Steg>)retur;
    }


    public async Task<bool> Z_StegExistAsync(byte id)
    {
        return await Context.Z_Steg.AnyAsync(c => c.Storedpfu == id);
    }

    //public new Z_Veckodag Insert(Z_Veckodag Z_Veckodag)
    //{
    //    base.Insert(Z_Veckodag);
    //    return Z_Veckodag;
    //}

    //public new Z_Veckodag Update(Z_Veckodag Z_Veckodag)
    //{
    //    base.Update(Z_Veckodag);
    //    return Z_Veckodag;
    //}

    //public override void Delete(Z_Veckodag Z_Veckodag)
    //{
    //    base.Delete(Z_Veckodag);
    //}

}
