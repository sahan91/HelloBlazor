using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using HelloBlazor.App.Service;

namespace HelloBlazor.WASM
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<HelloBlazor.App.App>("app");

            builder.Services.AddScoped<WeatherForecastService>();

            await builder.Build().RunAsync();
        }
    }
}
