using System.Runtime.InteropServices;
using Matplan.Infrastructure.Repositories.Shared;
using Microsoft.EntityFrameworkCore;
using Matplan.Infrastructure.Data;
using Matplan.EntityModels;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Matplan.EntityModels.Models;
using Matplan.Shared.Requests;
using Matplan.EntityContracts.Repositories.Kodtabeller;
using Matplan.EntityContracts.Repositories.Shared;

namespace Matplan.Infrastructure.Repositories.Kodtabeller;

/*
				

-Z_ART_Grupp	byte:Storedpfu		string?:Displayed
-Z_Steg		byte:Storedpfu 		string?:Displayed
Z_Plandag	byte:Storedpfu 		string?:Displayed
Z_NejJa		byte:Storedpfu 		string?:Displayed
Z_Matratt	byte:Storedpfu 		string?:Displayed
Z_Maltid	byte:Storedpfu 		string?:Displayed
Z_Ja		byte:Storedpfu 		string?:Displayed
Z_Handlar	byte:Storedpfu 		string?:Displayed
Z_BristViaSMS	byte:Storedpfu 		string?:Displayed
Z_BeredInkop	byte:Storedpfu 		string?:Displayed
Z_ART_RecEnh	byte:Storedpfu 		string?:Displayed

Z_VG		string:Storedpfu	string?:DisplayedVG
Z_Kat		string:Storedpfu 	string?:Displayed
Z_HI		string:Storedpfu 	string?:Displayed
Z_ART_Typ	string:Storedpfu 	string?:Displayed
Z_ART_Lagring	string:Storedpfu 	string?:Displayed
Z_ART_Grupp	string:Storedpfu 	string?:Displayed

Z_Datum		DateTime:Datum 		string?:Dag

Z_ART_Enhet	string:Storedpfu 	
Z_AltBild	string:Storedpfu */
public class Z_ART_GruppRepository : RepositoryBase<Z_ART_Grupp>, IZ_ART_GruppRepository
{
    public Z_ART_GruppRepository(MatplanDBContext context) : base(context)
    {
    }

    public async Task<Z_ART_Grupp?> GetZ_ART_GruppAsync(string id, bool trackChanges = false)
    {
        var retur = await FindByCondition(c => c.Storedpfu.Equals(id), trackChanges).FirstOrDefaultAsync();
//        if (retur == null) throw new Z_ART_GruppNotFoundException(id);
        return retur;
    }


    public async Task<IPagedList<Z_ART_Grupp>> GetZ_ART_GruppListAsync(RequestParams requestParams, bool trackChanges = false)
    {
        var query = FindAll(trackChanges);
        query = query.OrderBy(o => o.Storedpfu);

        var retur = await PagedList<Z_ART_Grupp>.CreateAsync(query, requestParams.PageNumber, requestParams.PageSize);
        return (IPagedList<Z_ART_Grupp>)retur;
    }


    public async Task<bool> Z_ART_GruppExistAsync(string id)
    {
        return await Context.Z_ART_Grupp.AnyAsync(c => c.Storedpfu == id);
    }

    //public new Z_ART_Grupp Insert(Z_ART_Grupp Z_ART_Grupp)
    //{
    //    base.Insert(Z_ART_Grupp);
    //    return Z_ART_Grupp;
    //}

    //public new Z_ART_Grupp Update(Z_ART_Grupp Z_ART_Grupp)
    //{
    //    base.Update(Z_ART_Grupp);
    //    return Z_ART_Grupp;
    //}

    //public override void Delete(Z_ART_Grupp Z_ART_Grupp)
    //{
    //    base.Delete(Z_ART_Grupp);
    //}

 
}

