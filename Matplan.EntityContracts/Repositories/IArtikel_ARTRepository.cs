using Matplan.EntityContracts.Repositories.Shared;
using Matplan.EntityModels.Models;
using Matplan.Shared.Paginering;
using Matplan.Shared.Requests;

namespace Matplan.EntityContracts.Repositories;

public interface IArtikel_ARTRepository
{
    Task<Artikel_ART?> GetArtikel_ARTAsync(int id, bool trackChanges = false);
    Task<IPagedList<Artikel_ART>> GetArtikel_ARTListAsync(ArtikelRequestParams requestParams, bool trackChanges = false);
    Task<bool> Artikel_ARTExistAsync(int id);
    void Insert(Artikel_ART Artikel);
    void Update(Artikel_ART Artikel);
    void Delete(Artikel_ART Artikel);


}