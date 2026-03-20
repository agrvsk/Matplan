using Matplan.Blazor.Client.Pages;
using Matplan.Blazor.Client.Services;
using Matplan.Blazor.Components;
using Matplan.Blazor.Services;
using Matplan.Blazor.Services.NoOpService;

namespace Matplan.Blazor;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);


        // Add services to the container.
        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents()
            .AddInteractiveWebAssemblyComponents();
        
        builder.Services.AddControllers();

        // HTTP Client configuration
        builder.Services.AddHttpClient("MatplanAPIClient", cfg =>
        {
            cfg.BaseAddress = new Uri(builder.Configuration["MatplanAPIBaseAddress"] ?? throw new Exception("MatplanAPIBaseAddress is missing."));
        });

        builder.Services.AddScoped<IApiService, ServerNoopApiService>();
        builder.Services.AddScoped<IAuthReadyService, ServerNoopAuthReadyService>();
        builder.Services.AddScoped<ILookupService, ServerNoopLookupService>();

        //builder.Services.AddScoped<IApiServiceServer, ServerApiService>();

        // Token storage service
        builder.Services.AddSingleton<ITokenStorage, TokenStorageService>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseWebAssemblyDebugging();
        }
        else
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        //app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
        app.UseHttpsRedirection();
        app.UseRouting();

        app.MapStaticAssets();
        app.MapControllers().AllowAnonymous(); 

        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode()
            .AddInteractiveWebAssemblyRenderMode()
            .AddAdditionalAssemblies(typeof(Client._Imports).Assembly);

        app.UseAntiforgery();

        app.Run();
    }
}
