using System.Threading.Tasks;
using System.Net.Http.Json;
using HelloBlazor.Shared;

namespace HelloBlazor.WASM.Pages
{
    public partial class FetchData
    {
        private WeatherForecast[] _forecasts;

        protected override async Task OnInitializedAsync()
        {
            _forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }
    }
}
