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
				

-Z_Plandag	byte:Storedpfu		string?:Displayed
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
public class Z_PlandagRepository : RepositoryBase<Z_Plandag>, IZ_PlandagRepository
{
    public Z_PlandagRepository(MatplanDBContext context) : base(context)
    {
    }

    public async Task<Z_Plandag?> GetZ_PlandagAsync(byte id, bool trackChanges = false)
    {
        var retur = await FindByCondition(c => c.Storedpfu.Equals(id), trackChanges).FirstOrDefaultAsync();
//        if (retur == null) throw new Z_PlandagNotFoundException(id);
        return retur;
    }


    public async Task<IPagedList<Z_Plandag>> GetZ_PlandagListAsync(KodtabellByteRequestParams requestParams, bool trackChanges = false)
    {
        var query = FindAll(trackChanges);
        query = query.OrderBy(o => o.Storedpfu);

        var retur = await PagedList<Z_Plandag>.CreateAsync(query, requestParams.PageNumber, requestParams.PageSize);
        return (IPagedList<Z_Plandag>)retur;
    }


    public async Task<bool> Z_PlandagExistAsync(byte id)
    {
        return await Context.Z_Plandag.AnyAsync(c => c.Storedpfu == id);
    }

    //public new Z_Plandag Insert(Z_Plandag Z_Plandag)
    //{
    //    base.Insert(Z_Plandag);
    //    return Z_Plandag;
    //}

    //public new Z_Plandag Update(Z_Plandag Z_Plandag)
    //{
    //    base.Update(Z_Plandag);
    //    return Z_Plandag;
    //}

    //public override void Delete(Z_Plandag Z_Plandag)
    //{
    //    base.Delete(Z_Plandag);
    //}

 
}

