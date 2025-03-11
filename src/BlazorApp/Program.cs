using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorApp;
using BlazorApp.Services;
using System.Globalization;
using BlazorApp.Shared.Extensions;

var builder = WebAssemblyHostBuilder.CreateDefault(args);


builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<HeroImageService>();

builder.Services.AddLocalization();
var host = builder.Build();
await host.SetDefaultCulture();
await host.RunAsync();


var app = builder.Build();

var culture = new CultureInfo("de");
CultureInfo.DefaultThreadCurrentCulture = culture;
CultureInfo.DefaultThreadCurrentUICulture = culture;


await builder.Build().RunAsync();



