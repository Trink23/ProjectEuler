using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ProjectEuler;
using RazorClassLibrary1.DataServices;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddHttpClient<ISpaceXDataService, RESTSpaceXDataService>(spds => spds.BaseAddress = new Uri(builder.Configuration["api_base_url"]));

await builder.Build().RunAsync();

