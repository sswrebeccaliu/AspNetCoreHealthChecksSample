using AspNetCoreHealthChecksSample.Models;
using AspNetCoreHealthChecksSample.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace AspNetCoreHealthChecksSample.Pages
{
    public class FetchDataModel : PageModel
    {
        private readonly IWeatherForecastClient _client;

        public FetchDataModel(IWeatherForecastClient client)
        {
            _client = client;
        }

        public IEnumerable<WeatherForecast> Forecasts { get; set; }

        public void OnGet()
        {
            Forecasts = _client.Get();
        }
    }
}