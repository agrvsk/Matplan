using System;
using System.Collections.Generic;
using System.Text;
using Matplan.EntityContracts.Repositories;
using Matplan.EntityContracts.Repositories.Shared;
using Matplan.EntityModels.Models;
using Matplan.Infrastructure.Data;
using Matplan.Infrastructure.Repositories.Shared;
using Matplan.Shared.Requests;
using Microsoft.EntityFrameworkCore;

namespace Matplan.Infrastructure.Repositories;

public class Bill_Of_Material_BOMRepository : RepositoryBase<Bill_Of_Material_BOM>, IBill_Of_Material_BOMRepository
{
    public Bill_Of_Material_BOMRepository(MatplanDBContext context) : base(context)
    {
    }

    public async Task<Bill_Of_Material_BOM?> GetBill_Of_Material_BOMAsync(long ArtikelNr, long OpNr, long OpOrdNr, bool trackChanges = false)
    {
        var retur = await FindByCondition(c => c.BOM_ArtikelNr == ArtikelNr
                                            && c.BOM_OpNr == OpNr
                                            && c.BOM_OpOrdNr == OpOrdNr, trackChanges).FirstOrDefaultAsync();
        //        if (retur == null) throw new Artikel_ARTNotFoundException(id);
        return retur;
    }


    public async Task<IPagedList<Bill_Of_Material_BOM>> GetBill_Of_Material_BOMListAsync(BomRequestParams requestParams, bool trackChanges = false)
    {
        var query = FindAll(trackChanges);
        query = query.OrderBy(o => o.BOM_ArtikelNr);

        var retur = await PagedList<Bill_Of_Material_BOM>.CreateAsync(query, requestParams.PageNumber, requestParams.PageSize);
        return (IPagedList<Bill_Of_Material_BOM>)retur;
    }


    public async Task<bool> Bill_Of_Material_BOMExistAsync(long ArtikelNr, long OpNr, long OpOrdNr)
    {
        return await Context.Bill_Of_Material_BOM.AnyAsync(c => c.BOM_ArtikelNr == ArtikelNr 
                                                             && c.BOM_OpNr == OpNr
                                                             && c.BOM_OpOrdNr == OpOrdNr);
    }

    //public new Bill_Of_Material_BOM Insert(Bill_Of_Material_BOM Bill_Of_Material_BOM)
    //{
    //    base.Insert(Bill_Of_Material_BOM);
    //    return Bill_Of_Material_BOM;
    //}

    //public new Bill_Of_Material_BOM Update(Bill_Of_Material_BOM Bill_Of_Material_BOM)
    //{
    //    base.Update(Bill_Of_Material_BOM);
    //    return Bill_Of_Material_BOM;
    //}

    //public override void Delete(Artikel_ART Artikel_ART)
    //{
    //    base.Delete(Artikel_ART);
    //}

}
