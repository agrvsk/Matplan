using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Matplan.EntityModels.Models;
using Matplan.Infrastructure.Data;
using Matplan.EntityContracts.Repositories.Shared;
using Matplan.EntityContracts.Repositories.Kodtabeller;
using Matplan.EntityContracts.Repositories;

namespace Matplan.Infrastructure.Repositories.Shared;

public class UnitOfWork : IUnitOfWork
{
    private readonly MatplanDBContext _context;

    #region Kodtabeller
    private readonly Lazy<IZ_VeckodagRepository> Z_VeckodagRepoLazy;
    private readonly Lazy<IZ_StegRepository> Z_StegRepoLazy;
    private readonly Lazy<IZ_PlandagRepository> Z_PlandagRepoLazy;
    private readonly Lazy<IZ_NejJaRepository> Z_NejJaRepoLazy;
    private readonly Lazy<IZ_MatrattRepository> Z_MatrattRepoLazy;
    private readonly Lazy<IZ_MaltidRepository> Z_MaltidRepoLazy;
    private readonly Lazy<IZ_JaRepository> Z_JaRepoLazy;
    private readonly Lazy<IZ_HandlarRepository> Z_HandlarRepoLazy;
    private readonly Lazy<IZ_BristViaSMSRepository> Z_BristViaSMSRepoLazy;
    private readonly Lazy<IZ_BeredInkopRepository> Z_BeredInkopRepoLazy;
    private readonly Lazy<IZ_ART_RecEnhRepository> Z_ART_RecEnhRepoLazy;
    private readonly Lazy<IZ_VGRepository> Z_VGRepoLazy;
    private readonly Lazy<IZ_KatRepository> Z_KatRepoLazy;
    private readonly Lazy<IZ_HIRepository> Z_HIRepoLazy;
    private readonly Lazy<IZ_ART_TypRepository> Z_ART_TypRepoLazy;
    private readonly Lazy<IZ_ART_LagringRepository> Z_ART_LagringRepoLazy;
    private readonly Lazy<IZ_ART_GruppRepository> Z_ART_GruppRepoLazy;
    private readonly Lazy<IZ_DatumRepository> Z_DatumRepoLazy;
    private readonly Lazy<IZ_ART_EnhetRepository> Z_ART_EnhetRepoLazy;
    private readonly Lazy<IZ_AltBildRepository> Z_AltBildRepoLazy;
    #endregion



    #region Kodtabeller Public Properties
    public IZ_VeckodagRepository Z_VeckodagRepository => Z_VeckodagRepoLazy.Value;
    public IZ_StegRepository Z_StegRepository => Z_StegRepoLazy.Value;
    public IZ_PlandagRepository Z_PlandagRepository => Z_PlandagRepoLazy.Value;
    public IZ_NejJaRepository Z_NejJaRepository => Z_NejJaRepoLazy.Value;
    public IZ_MatrattRepository Z_MatrattRepository => Z_MatrattRepoLazy.Value;
    public IZ_MaltidRepository Z_MaltidRepository => Z_MaltidRepoLazy.Value;
    public IZ_JaRepository Z_JaRepository => Z_JaRepoLazy.Value;
    public IZ_HandlarRepository Z_HandlarRepository => Z_HandlarRepoLazy.Value;
    public IZ_BristViaSMSRepository Z_BristViaSMSRepository => Z_BristViaSMSRepoLazy.Value;
    public IZ_BeredInkopRepository Z_BeredInkopRepository => Z_BeredInkopRepoLazy.Value;
    public IZ_ART_RecEnhRepository Z_ART_RecEnhRepository => Z_ART_RecEnhRepoLazy.Value;
    public IZ_VGRepository Z_VGRepository => Z_VGRepoLazy.Value;
    public IZ_KatRepository Z_KatRepository => Z_KatRepoLazy.Value;
    public IZ_HIRepository Z_HIRepository => Z_HIRepoLazy.Value;
    public IZ_ART_TypRepository Z_ART_TypRepository => Z_ART_TypRepoLazy.Value;
    public IZ_ART_LagringRepository Z_ART_LagringRepository => Z_ART_LagringRepoLazy.Value;
    public IZ_ART_GruppRepository Z_ART_GruppRepository => Z_ART_GruppRepoLazy.Value;
    public IZ_DatumRepository Z_DatumRepository => Z_DatumRepoLazy.Value;
    public IZ_ART_EnhetRepository Z_ART_EnhetRepository => Z_ART_EnhetRepoLazy.Value;
    public IZ_AltBildRepository Z_AltBildRepository => Z_AltBildRepoLazy.Value;
    #endregion

    //Z_Veckodag byte:Storedpfu string?:Displayed
    //Z_Steg      byte:Storedpfu string?:Displayed
    //Z_Plandag   byte:Storedpfu string?:Displayed
    //Z_NejJa     byte:Storedpfu string?:Displayed
    //Z_Matratt   byte:Storedpfu string?:Displayed
    //Z_Maltid    byte:Storedpfu string?:Displayed
    //Z_Ja        byte:Storedpfu string?:Displayed
    //Z_Handlar   byte:Storedpfu string?:Displayed
    //Z_BristViaSMS   byte:Storedpfu string?:Displayed
    //Z_BeredInkop    byte:Storedpfu string?:Displayed
    //Z_ART_RecEnh    byte:Storedpfu string?:Displayed

    //Z_VG        string:Storedpfu string?:DisplayedVG
    //Z_Kat       string:Storedpfu string?:Displayed
    //Z_HI        string:Storedpfu string?:Displayed
    //Z_ART_Typ   string:Storedpfu string?:

    //Z_ART_Lagring   string:Storedpfu string?:Displayed
    //Z_ART_Grupp string:Storedpfu string?:Displayed

    //Z_Datum     DateTime:Datum string?:Dag

    //Z_ART_Enhet string:Storedpfu
    //Z_AltBild   string:Storedpfu

    private readonly Lazy<IArtikel_ARTRepository> Artikel_ARTRepoLazy;
    public IArtikel_ARTRepository Artikel_ARTRepository => Artikel_ARTRepoLazy.Value;


    public UnitOfWork(
        MatplanDBContext context,
        Lazy<IZ_VeckodagRepository> Z_VeckodagArg,
        Lazy<IZ_StegRepository> Z_StegArg,
        Lazy<IZ_PlandagRepository> Z_PlandagArg,
        Lazy<IZ_NejJaRepository> Z_NejJaArg,
        Lazy<IZ_MatrattRepository> Z_MatrattArg,
        Lazy<IZ_MaltidRepository> Z_MaltidArg,
        Lazy<IZ_JaRepository> Z_JaArg,
        Lazy<IZ_HandlarRepository> Z_HandlarArg,
        Lazy<IZ_BristViaSMSRepository> Z_BristViaSMSArg,
        Lazy<IZ_BeredInkopRepository> Z_BeredInkopArg,
        Lazy<IZ_ART_RecEnhRepository> Z_ART_RecEnhArg,
        Lazy<IZ_VGRepository> Z_VGArg,
        Lazy<IZ_KatRepository> Z_KatArg,
        Lazy<IZ_HIRepository> Z_HIArg,
        Lazy<IZ_ART_TypRepository> Z_ART_TypArg,
        Lazy<IZ_ART_LagringRepository> Z_ART_LagringArg,
        Lazy<IZ_ART_GruppRepository> Z_ART_GruppArg,
        Lazy<IZ_DatumRepository> Z_DatumArg,
        Lazy<IZ_ART_EnhetRepository> Z_ART_EnhetArg,
        Lazy<IZ_AltBildRepository> Z_AltBildArg,

        Lazy<IArtikel_ARTRepository> ArtikelArg
        )
    {
        _context = context;
        Z_VeckodagRepoLazy = Z_VeckodagArg;
        Z_StegRepoLazy = Z_StegArg;
        Z_PlandagRepoLazy = Z_PlandagArg;
        Z_NejJaRepoLazy = Z_NejJaArg;
        Z_MatrattRepoLazy =  Z_MatrattArg;
        Z_MaltidRepoLazy =  Z_MaltidArg;
        Z_JaRepoLazy =  Z_JaArg;
        Z_HandlarRepoLazy =  Z_HandlarArg;
        Z_BristViaSMSRepoLazy =  Z_BristViaSMSArg;
        Z_BeredInkopRepoLazy =  Z_BeredInkopArg;
        Z_ART_RecEnhRepoLazy =  Z_ART_RecEnhArg;
        Z_VGRepoLazy =  Z_VGArg;
        Z_KatRepoLazy =  Z_KatArg;
        Z_HIRepoLazy =  Z_HIArg;
        Z_ART_TypRepoLazy =  Z_ART_TypArg;
        Z_ART_LagringRepoLazy =  Z_ART_LagringArg;
        Z_ART_GruppRepoLazy =  Z_ART_GruppArg;
        Z_DatumRepoLazy =  Z_DatumArg;
        Z_ART_EnhetRepoLazy =  Z_ART_EnhetArg;
        Z_AltBildRepoLazy =  Z_AltBildArg;

        Artikel_ARTRepoLazy = ArtikelArg;

    }



    //public async Task CompleteAsync()
    //{
    //    foreach (var orderItem in _context.ChangeTracker.Entries<OrderItem>())
    //    {
    //        Product? product = null;

    //        if (orderItem.Entity.ShopifyProductQL != null 
    //        &&  orderItem.Entity.ShopifyVariantQL != null)
    //        {
    //            product = await _context.Products
    //            .FirstOrDefaultAsync(p =>
    //                p.ShopifyProductQL == orderItem.Entity.ShopifyProductQL &&
    //                p.ShopifyVariantQL == orderItem.Entity.ShopifyVariantQL
    //            );
    //        }
    //        if (product == null
    //        && orderItem.Entity.ShopifyProductId != null && orderItem.Entity.ShopifyProductId != 0
    //        && orderItem.Entity.ShopifyVariantId != null && orderItem.Entity.ShopifyVariantId != 0)
    //        {
    //            product = await _context.Products
    //            .FirstOrDefaultAsync(p =>
    //                p.ShopifyProductId == orderItem.Entity.ShopifyProductId &&
    //                p.ShopifyVariant == orderItem.Entity.ShopifyVariantId
    //            );
    //        }

    //        if (product != null) //Sätter automatiskt övriga nycklar
    //        {
    //            orderItem.Entity.ShopifyProductQL = product.ShopifyProductQL;
    //            orderItem.Entity.ShopifyVariantQL = product.ShopifyVariantQL;
    //            orderItem.Entity.ShopifyProductId = product.ShopifyProductId;
    //            orderItem.Entity.ShopifyVariantId = product.ShopifyVariant;
    //            orderItem.Entity.ProductId = product.ProductId;
    //        }
    //    }
    //    await _context.SaveChangesAsync();
    //}

    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }
    public void Clear()
    {
        _context.ChangeTracker.Clear();
    }


}