using BlazorApp.Client.Client;
using MatBlazor;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

namespace BlazorApp.Client.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NzIxODI0QDMyMzAyZTMyMmUzMGxiYXNvcUhzZ2JPbUJtdW01cmFiY3BmZlViWEdaTDZINDNtbG1oTjF2RWc9");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSyncfusionBlazor();
            builder.Services.AddMatBlazor();
            await builder.Build().RunAsync();
        }
    }
}
// api key 1 : NzIxODIyQDMyMzAyZTMyMmUzMGxiYXNvcUhzZ2JPbUJtdW01cmFiY3BmZlViWEdaTDZINDNtbG1oTjF2RWc9
//api key 2 :  NzIxODI0QDMyMzAyZTMyMmUzMGxiYXNvcUhzZ2JPbUJtdW01cmFiY3BmZlViWEdaTDZINDNtbG1oTjF2RWc9