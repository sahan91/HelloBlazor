using HelloRazor.App.Service;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace HelloBlazor.WASM
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<HelloRazor.App.App>("app");

            builder.Services.AddScoped<WeatherForecastService>();

            await builder.Build().RunAsync();
        }
    }
}
