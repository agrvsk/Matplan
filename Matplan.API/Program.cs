using Matplan.API.Extensions;
using Matplan.Infrastructure.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Abstractions;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.Resource;

namespace Matplan.API;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Configuration
        .AddJsonFile("appsettings.Local.json", optional: true, reloadOnChange: true)
        .AddUserSecrets<Program>(optional: true)
        .AddEnvironmentVariables();

        builder.Services.ConfigureSql(builder.Configuration);
        builder.Services.ConfigureControllers();    
        builder.Services.AddRepositoryLayer();
        builder.Services.AddServiceLayer();


        // Add services to the container.
        //builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        //    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

        builder.Services.ConfigureAuthentication(builder.Configuration);
        builder.Services.ConfigureIdentity(builder.Configuration);

//        builder.Services.AddHostedService<DataSeedHostingService>();
        builder.Services.AddAutoMapper(cfg => cfg.AddProfile<MapperProfile>());
        builder.Services.ConfigureCors();
        builder.Services.ConfigureOpenApi();


        var app = builder.Build();

        // --- WARM-UP QUERY ---
        app.Lifetime.ApplicationStarted.Register(async () =>
        {
            using var scope = app.Services.CreateScope();
            var db = scope.ServiceProvider.GetRequiredService<MatplanDBContext>();
            await db.Database.CanConnectAsync();
            await db.Artikel_ART.FirstOrDefaultAsync();
        });
        //using (var scope = app.Services.CreateScope())
        //{
        //    var db = scope.ServiceProvider.GetRequiredService<MatplanDBContext>();
        //    //await db.Database.CanConnectAsync();

        //    try
        //    {
        //        // Kör en minimal query som triggar EF-modellbyggandet
        //        var _ = db.Artikel_ART.FirstOrDefault();
        //        Console.WriteLine("Warm-up query completed");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Warm-up failed: {ex.Message}");
        //    }
        //}
        // --- END WARM-UP ---

        // Configure the HTTP request pipeline.
        //        app.ConfigureExceptionHandler();

        if (app.Environment.IsDevelopment())
        {
            //app.MapOpenApi();
            app.UseSwagger();
            app.UseSwaggerUI(opt =>
            {
                opt.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });

        }

        app.UseHttpsRedirection();
//      app.UseCors("AllowAll"); 
//      app.UseCors("CorsPolicy");

        app.UseAuthentication();
        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
