namespace Matplan.Services.Contracts;

public interface IServiceManager
{
    IKodtabellService KodtabellService { get; }
    IArtikelService ArtikelService { get; }

    IAuthService AuthService { get; }

}