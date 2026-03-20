using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Matplan.Services.Contracts;


namespace Matplan.Infrastructure.IdentityServices;

public class ServiceManager : IServiceManager
{
    private readonly Lazy<IKodtabellService> kodtabellServiceLazy;
    private readonly Lazy<IArtikelService> artikelServiceLazy;
    private readonly Lazy<IAuthService> authServiceLazy;

    public IKodtabellService KodtabellService => kodtabellServiceLazy.Value;
    public IArtikelService ArtikelService => artikelServiceLazy.Value;
    public IAuthService AuthService => authServiceLazy.Value;

    public ServiceManager(
        Lazy<IKodtabellService> kodtabellserviceArg,
        Lazy<IArtikelService> artikelserviceArg,
        Lazy<IAuthService> authserviceArg
        )
    {
        kodtabellServiceLazy = kodtabellserviceArg;
        artikelServiceLazy = artikelserviceArg;
        authServiceLazy = authserviceArg;
    }
}

