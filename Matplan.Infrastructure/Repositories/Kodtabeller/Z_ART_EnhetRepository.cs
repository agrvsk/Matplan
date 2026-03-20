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
				

-Z_ART_Enhet	byte:Storedpfu		string?:Displayed
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
public class Z_ART_EnhetRepository : RepositoryBase<Z_ART_Enhet>, IZ_ART_EnhetRepository
{
    public Z_ART_EnhetRepository(MatplanDBContext context) : base(context)
    {
    }

    public async Task<Z_ART_Enhet?> GetZ_ART_EnhetAsync(string id, bool trackChanges = false)
    {
        var retur = await FindByCondition(c => c.Storedpfu.Equals(id), trackChanges).FirstOrDefaultAsync();
//        if (retur == null) throw new Z_ART_EnhetNotFoundException(id);
        return retur;
    }


    public async Task<IPagedList<Z_ART_Enhet>> GetZ_ART_EnhetListAsync(RequestParams requestParams, bool trackChanges = false)
    {
        var query = FindAll(trackChanges);
        query = query.OrderBy(o => o.Storedpfu);

        var retur = await PagedList<Z_ART_Enhet>.CreateAsync(query, requestParams.PageNumber, requestParams.PageSize);
        return (IPagedList<Z_ART_Enhet>)retur;
    }


    public async Task<bool> Z_ART_EnhetExistAsync(string id)
    {
        return await Context.Z_ART_Enhet.AnyAsync(c => c.Storedpfu == id);
    }

    //public new Z_ART_Enhet Insert(Z_ART_Enhet Z_ART_Enhet)
    //{
    //    base.Insert(Z_ART_Enhet);
    //    return Z_ART_Enhet;
    //}

    //public new Z_ART_Enhet Update(Z_ART_Enhet Z_ART_Enhet)
    //{
    //    base.Update(Z_ART_Enhet);
    //    return Z_ART_Enhet;
    //}

    //public override void Delete(Z_ART_Enhet Z_ART_Enhet)
    //{
    //    base.Delete(Z_ART_Enhet);
    //}

 
}

