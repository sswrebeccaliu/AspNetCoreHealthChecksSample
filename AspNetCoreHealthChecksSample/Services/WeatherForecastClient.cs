using AspNetCoreHealthChecksSample.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCoreHealthChecksSample.Services
{
    public class WeatherForecastClient : IWeatherForecastClient
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastClient> _logger;

        public WeatherForecastClient(ILogger<WeatherForecastClient> logger)
        {
            _logger = logger;
        }

        public bool IsHealthy()
        {
            return true;
        }

        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
