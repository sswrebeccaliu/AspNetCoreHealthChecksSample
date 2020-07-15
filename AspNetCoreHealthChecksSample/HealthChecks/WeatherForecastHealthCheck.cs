using AspNetCoreHealthChecksSample.Services;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Threading;
using System.Threading.Tasks;

namespace AspNetCoreHealthChecksSample.HealthChecks
{
    public class WeatherForecastHealthCheck : IHealthCheck
    {
        private readonly IWeatherForecastClient _weatherForecastClient;

        public WeatherForecastHealthCheck(IWeatherForecastClient weatherForecastClient)
        {
            _weatherForecastClient = weatherForecastClient;
        }

        public Task<HealthCheckResult> CheckHealthAsync(
            HealthCheckContext context,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            if (_weatherForecastClient.IsHealthy())
            {
                return Task.FromResult(
                    HealthCheckResult.Healthy("The service is online."));
            }

            return Task.FromResult(
                HealthCheckResult.Degraded("The service is offline."));
        }
    }
}
