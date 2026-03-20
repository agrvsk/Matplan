using Matplan.EntityContracts.Repositories.Kodtabeller;

namespace Matplan.EntityContracts.Repositories.Shared;

public interface IUnitOfWork
{
    #region Kodtabeller
    IZ_VeckodagRepository Z_VeckodagRepository { get; }
    IZ_StegRepository Z_StegRepository { get; } 
    IZ_PlandagRepository Z_PlandagRepository { get; } 
    IZ_NejJaRepository Z_NejJaRepository { get; } 
    IZ_MatrattRepository Z_MatrattRepository { get; } 
    IZ_MaltidRepository Z_MaltidRepository { get; } 
    IZ_JaRepository Z_JaRepository { get; } 
    IZ_HandlarRepository Z_HandlarRepository { get; } 
    IZ_BristViaSMSRepository Z_BristViaSMSRepository { get; } 
    IZ_BeredInkopRepository Z_BeredInkopRepository { get; } 
    IZ_ART_RecEnhRepository Z_ART_RecEnhRepository { get; } 
    IZ_VGRepository Z_VGRepository { get; } 
    IZ_KatRepository Z_KatRepository { get; } 
    IZ_HIRepository Z_HIRepository { get; } 
    IZ_ART_TypRepository Z_ART_TypRepository { get; } 
    IZ_ART_LagringRepository Z_ART_LagringRepository { get; } 
    IZ_ART_GruppRepository Z_ART_GruppRepository { get; } 
    IZ_DatumRepository Z_DatumRepository { get; } 
    IZ_ART_EnhetRepository Z_ART_EnhetRepository { get; } 
    IZ_AltBildRepository Z_AltBildRepository { get; }
    #endregion

    IArtikel_ARTRepository Artikel_ARTRepository { get; }

    Task SaveAsync();

    void Clear();

}