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
				

-Z_ART_Typ	byte:Storedpfu		string?:Displayed
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
public class Z_ART_TypRepository : RepositoryBase<Z_ART_Typ>, IZ_ART_TypRepository
{
    public Z_ART_TypRepository(MatplanDBContext context) : base(context)
    {
    }

    public async Task<Z_ART_Typ?> GetZ_ART_TypAsync(string id, bool trackChanges = false)
    {
        var retur = await FindByCondition(c => c.Storedpfu.Equals(id), trackChanges).FirstOrDefaultAsync();
//        if (retur == null) throw new Z_ART_TypNotFoundException(id);
        return retur;
    }


    public async Task<IPagedList<Z_ART_Typ>> GetZ_ART_TypListAsync(RequestParams requestParams, bool trackChanges = false)
    {
        var query = FindAll(trackChanges);
        query = query.OrderBy(o => o.Storedpfu);

        var retur = await PagedList<Z_ART_Typ>.CreateAsync(query, requestParams.PageNumber, requestParams.PageSize);
        return (IPagedList<Z_ART_Typ>)retur;
    }


    public async Task<bool> Z_ART_TypExistAsync(string id)
    {
        return await Context.Z_ART_Typ.AnyAsync(c => c.Storedpfu == id);
    }

    //public new Z_ART_Typ Insert(Z_ART_Typ Z_ART_Typ)
    //{
    //    base.Insert(Z_ART_Typ);
    //    return Z_ART_Typ;
    //}

    //public new Z_ART_Typ Update(Z_ART_Typ Z_ART_Typ)
    //{
    //    base.Update(Z_ART_Typ);
    //    return Z_ART_Typ;
    //}

    //public override void Delete(Z_ART_Typ Z_ART_Typ)
    //{
    //    base.Delete(Z_ART_Typ);
    //}

 
}

