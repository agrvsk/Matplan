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
				

-Z_Datum	byte:Storedpfu		string?:Displayed
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
public class Z_DatumRepository : RepositoryBase<Z_Datum>, IZ_DatumRepository
{
    public Z_DatumRepository(MatplanDBContext context) : base(context)
    {
    }

    public async Task<Z_Datum?> GetZ_DatumAsync(DateTime id, bool trackChanges = false)
    {
        var retur = await FindByCondition(c => c.Datum.Equals(id), trackChanges).FirstOrDefaultAsync();
//        if (retur == null) throw new Z_DatumNotFoundException(id);
        return retur;
    }


    public async Task<IPagedList<Z_Datum>> GetZ_DatumListAsync(RequestParams requestParams, bool trackChanges = false)
    {
        var query = FindAll(trackChanges);
        query = query.OrderBy(o => o.Datum);

        var retur = await PagedList<Z_Datum>.CreateAsync(query, requestParams.PageNumber, requestParams.PageSize);
        return (IPagedList<Z_Datum>)retur;
    }


    public async Task<bool> Z_DatumExistAsync(DateTime id)
    {
        return await Context.Z_Datum.AnyAsync(c => c.Datum == id);
    }

    //public new Z_Datum Insert(Z_Datum Z_Datum)
    //{
    //    base.Insert(Z_Datum);
    //    return Z_Datum;
    //}

    //public new Z_Datum Update(Z_Datum Z_Datum)
    //{
    //    base.Update(Z_Datum);
    //    return Z_Datum;
    //}

    //public override void Delete(Z_Datum Z_Datum)
    //{
    //    base.Delete(Z_Datum);
    //}

 
}

