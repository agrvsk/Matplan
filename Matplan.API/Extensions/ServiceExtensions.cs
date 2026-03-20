using Matplan.EntityContracts.Repositories;
using Matplan.EntityContracts.Repositories.Kodtabeller;
using Matplan.EntityContracts.Repositories.Shared;
using Matplan.Infrastructure.Data;
using Matplan.Infrastructure.IdentityServices;
using Matplan.Infrastructure.Repositories;
using Matplan.Infrastructure.Repositories.Kodtabeller;
using Matplan.Infrastructure.Repositories.Shared;
using Matplan.Services;
using Matplan.Services.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;

namespace Matplan.API.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureCors(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            //ToDo: Restrict access to your BlazorApp only!
            options.AddDefaultPolicy(policy =>
            {
                //policy.WithOrigins("https://astrixlms.azurewebsites.net")
                //       .AllowAnyHeader()
                //       .AllowAnyMethod();
            });
            options.AddPolicy("CorsPolicy", p =>
                p.WithOrigins(
                    "https://astrixlms.azurewebsites.net",
                    "http://185.113.98.202"
                 )
                 .AllowAnyMethod()
                 .AllowAnyHeader()
                 .AllowCredentials());

            //Can be used during development
            options.AddPolicy("AllowAll", p =>
               p.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader());
        });
    }

    public static void ConfigureOpenApi(this IServiceCollection services) =>
       services.AddEndpointsApiExplorer()
               .AddSwaggerGen(setup =>
               {
                   setup.EnableAnnotations();
                   setup.SchemaFilter<DisplayEnumSchemaFilter>();

                   setup.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                   {
                       In = ParameterLocation.Header,
                       Description = "Place to add JWT with Bearer",
                       Name = "Authorization",
                       Type = SecuritySchemeType.Http,
                       Scheme = "Bearer"
                   });

                   setup.AddSecurityRequirement(new OpenApiSecurityRequirement
                   {
                        {
                            new Microsoft.OpenApi.Models.OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Id = "Bearer",
                                    Type = ReferenceType.SecurityScheme
                                }
                            },
                            new List<string>()
                        }
                   });
               });

    public static void ConfigureControllers(this IServiceCollection services)
    {
        services.AddControllers(opt =>
        {
            opt.ReturnHttpNotAcceptable = true;
            opt.Filters.Add(new ProducesAttribute("application/json"));

        })
        .AddNewtonsoftJson()
        .AddJsonOptions(o =>
        {
            o.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
        })

        ; //.AddApplicationPart(typeof(AssemblyReference).Assembly);

    }

    public static void ConfigureSql(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<MatplanDBContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.")));

        //services.AddIdentity<User_USR, IdentityRole>()
        //    .AddEntityFrameworkStores<ApplicationDBContext>()
        //    .AddDefaultTokenProviders();
    }

    public static void AddRepositoryLayer(this IServiceCollection services)
    {
        //services.AddScoped<IPagedList<T>, PagedList<T>>();
        services.AddScoped(typeof(IPagedList<>), typeof(PagedList<>));

        services.AddScoped<IZ_VeckodagRepository, Z_VeckodagRepository>();
        services.AddScoped<IZ_StegRepository, Z_StegRepository>();
        services.AddScoped<IZ_PlandagRepository, Z_PlandagRepository>();
        services.AddScoped<IZ_NejJaRepository, Z_NejJaRepository>();
        services.AddScoped<IZ_MatrattRepository, Z_MatrattRepository>();
        services.AddScoped<IZ_MaltidRepository, Z_MaltidRepository>();
        services.AddScoped<IZ_JaRepository, Z_JaRepository>();
        services.AddScoped<IZ_HandlarRepository, Z_HandlarRepository>();
        services.AddScoped<IZ_BristViaSMSRepository, Z_BristViaSMSRepository>();
        services.AddScoped<IZ_BeredInkopRepository, Z_BeredInkopRepository>();
        services.AddScoped<IZ_ART_RecEnhRepository, Z_ART_RecEnhRepository>();
        services.AddScoped<IZ_VGRepository, Z_VGRepository>();
        services.AddScoped<IZ_KatRepository, Z_KatRepository>();
        services.AddScoped<IZ_HIRepository, Z_HIRepository>();
        services.AddScoped<IZ_ART_TypRepository, Z_ART_TypRepository>();
        services.AddScoped<IZ_ART_LagringRepository, Z_ART_LagringRepository>();
        services.AddScoped<IZ_ART_GruppRepository, Z_ART_GruppRepository>();
        services.AddScoped<IZ_DatumRepository, Z_DatumRepository>();
        services.AddScoped<IZ_ART_EnhetRepository, Z_ART_EnhetRepository>();
        services.AddScoped<IZ_AltBildRepository, Z_AltBildRepository>();

        services.AddLazy<IZ_VeckodagRepository>();
        services.AddLazy<IZ_StegRepository>();
        services.AddLazy<IZ_PlandagRepository>();
        services.AddLazy<IZ_NejJaRepository>();
        services.AddLazy<IZ_MatrattRepository>();
        services.AddLazy<IZ_MaltidRepository>();
        services.AddLazy<IZ_JaRepository>();
        services.AddLazy<IZ_HandlarRepository>();
        services.AddLazy<IZ_BristViaSMSRepository>();
        services.AddLazy<IZ_BeredInkopRepository>();
        services.AddLazy<IZ_ART_RecEnhRepository>();
        services.AddLazy<IZ_VGRepository>();
        services.AddLazy<IZ_KatRepository>();
        services.AddLazy<IZ_HIRepository>();
        services.AddLazy<IZ_ART_TypRepository>();
        services.AddLazy<IZ_ART_LagringRepository>();
        services.AddLazy<IZ_ART_GruppRepository>();
        services.AddLazy<IZ_DatumRepository>();
        services.AddLazy<IZ_ART_EnhetRepository>();
        services.AddLazy<IZ_AltBildRepository>();

        services.AddScoped<IArtikel_ARTRepository, Artikel_ARTRepository>();
        services.AddLazy<IArtikel_ARTRepository>();


        services.AddScoped<IUnitOfWork, UnitOfWork>();

    }

    public static void AddServiceLayer(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();
        services.AddLazy<IAuthService>();

        services.AddScoped<IKodtabellService, KodtabellService>();
        services.AddLazy<IKodtabellService>();

        services.AddScoped<IArtikelService, ArtikelService>();
        services.AddLazy<IArtikelService>();

        services.AddScoped<IServiceManager, ServiceManager>();

    }



}

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddLazy<TService>(this IServiceCollection services) where TService : class
    {
        return services.AddScoped(provider => new Lazy<TService>(() => provider.GetRequiredService<TService>()));
    }
}

