
//using Domain.Models.Configurations;

//Project Infrastructure
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Matplan.Infrastructure.Data;
using Matplan.Infrastructure.IdentityModel;
using Matplan.Shared.Configurations;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Matplan.API.Extensions;

public static class AuthServiceExtension
{
    //User Secrets Json
    //Important to have secretkey inside same key "JwtSettings" as used in appsettings.json for get both sections!!!!
    //{
    //     "password": "YourSecretPasswordHere",
    //     "JwtSettings": {
    //        "secretkey": "ThisMustBeReallyLong!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!"
    //        }
    //}
    public static void ConfigureAuthentication(this IServiceCollection services, IConfiguration configuration)
    {
        var jwtSettings = configuration
                         .GetSection(JwtSettings.Section)
                         .Get<JwtSettings>()
                         ?? throw new InvalidOperationException("JwtSettings section is missing or invalid.");

        services.AddOptions<JwtSettings>()
                        .Bind(configuration.GetSection(JwtSettings.Section))
                        .Validate(config => !string.IsNullOrWhiteSpace(config.SecretKey), "SecretKey is required")
                        .ValidateDataAnnotations();

        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
           .AddJwtBearer(options =>
           {
               options.TokenValidationParameters = new TokenValidationParameters
               {
                   ValidateIssuer = true,
                   ValidateAudience = true,
                   ValidateLifetime = true,
                   ValidateIssuerSigningKey = true,
                   ValidIssuer = jwtSettings.Issuer,
                   ValidAudience = jwtSettings.Audience,
                   IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SecretKey)),
                   NameClaimType = JwtRegisteredClaimNames.Sub

               };
           });
    }

    public static void ConfigureIdentity(this IServiceCollection services, IConfiguration configuration)
    {
        //services.AddDbContext<ApplicationDBContext>(options =>
        //    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


//      services.AddIdentityCore<User_USR>(opt =>
        services.AddIdentity<User_USR, IdentityRole>(opt =>
        {
            //Just during development!
            opt.Password.RequireDigit = false;
            opt.Password.RequireLowercase = false;
            opt.Password.RequireUppercase = false;
            opt.Password.RequireNonAlphanumeric = false;
            opt.Password.RequiredLength = 3;

            opt.User.RequireUniqueEmail = false;

            // Disable passkeys (IMPORTANT)
            opt.SignIn.RequireConfirmedAccount = false;
            opt.SignIn.RequireConfirmedEmail = false;
            opt.SignIn.RequireConfirmedPhoneNumber = false;
            //opt.SignIn.RequireConfirmedPasskey = false;

        })
        //.AddRoles<IdentityRole>()
        .AddEntityFrameworkStores<MatplanDBContext>()
        .AddDefaultTokenProviders();
    }
}
