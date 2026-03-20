using System.Runtime.InteropServices;
using Matplan.Infrastructure.Repositories.Shared;
using Microsoft.EntityFrameworkCore;
using Matplan.Infrastructure.Data;
using Matplan.EntityModels;
using Matplan.EntityContracts.Repositories;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Matplan.EntityModels.Models;
using Matplan.Shared.Requests;
using Matplan.EntityContracts.Repositories.Shared;
//using Matplan.Shared.Requests;

namespace Matplan.Infrastructure.Repositories;

public class Artikel_ARTRepository : RepositoryBase<Artikel_ART>, IArtikel_ARTRepository
{
    public Artikel_ARTRepository(MatplanDBContext context) : base(context)
    {
    }

    public async Task<Artikel_ART?> GetArtikel_ARTAsync(int id, bool trackChanges = false)
    {
        var retur = await FindByCondition(c => c.ART_ArtikelNr.Equals(id), trackChanges).FirstOrDefaultAsync();
//        if (retur == null) throw new Artikel_ARTNotFoundException(id);
        return retur;
    }


    public async Task<IPagedList<Artikel_ART>> GetArtikel_ARTListAsync(ArtikelRequestParams requestParams, bool trackChanges = false)
    {
        var query = FindAll(trackChanges);

        if (!string.IsNullOrWhiteSpace(requestParams.Varugrupp))
        {
            query = query.Where(w => w.ART_VG == requestParams.Varugrupp);
        }

        //minimera datatrafiken genom att bara hämta de fält som behövs i listan
        query = query.Select(a => new Artikel_ART
        {
            ART_ArtikelNr = a.ART_ArtikelNr,
            ART_ArtikelNamn = a.ART_ArtikelNamn,
        });

        query = query.OrderBy(o => o.ART_ArtikelNr);

        var retur = await PagedList<Artikel_ART>.CreateAsync(query, requestParams.PageNumber, requestParams.PageSize);
        return (IPagedList<Artikel_ART>)retur;
    }


    public async Task<bool> Artikel_ARTExistAsync(int id)
    {
        return await Context.Artikel_ART.AnyAsync(c => c.ART_ArtikelNr == id);
    }

    //public new Artikel_ART Insert(Artikel_ART Artikel_ART)
    //{
    //    base.Insert(Artikel_ART);
    //    return Artikel_ART;
    //}

    //public new Artikel_ART Update(Artikel_ART Artikel_ART)
    //{
    //    base.Update(Artikel_ART);
    //    return Artikel_ART;
    //}

    //public override void Delete(Artikel_ART Artikel_ART)
    //{
    //    base.Delete(Artikel_ART);
    //}

 
}

