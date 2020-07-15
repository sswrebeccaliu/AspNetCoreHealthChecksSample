using AspNetCoreHealthChecksSample.Models;
using System.Collections.Generic;

namespace AspNetCoreHealthChecksSample.Services
{
    public interface IWeatherForecastClient
    {
        bool IsHealthy();
        IEnumerable<WeatherForecast> Get();
    }
}