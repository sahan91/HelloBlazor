using System;
using System.Threading.Tasks;
using HelloBlazor.Shared;
using HelloRazor.App.Service;
using Microsoft.AspNetCore.Components;

namespace HelloRazor.App.Pages
{
    public partial class FetchData
    {
        private WeatherForecast[] _forecasts;
        
        [Inject]
        public WeatherForecastService ForecastService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            _forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        }
    }
}
