using System;
using System.Threading.Tasks;

namespace HA.Data
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecast[]> GetForecastAsync(DateTime startDate);
    }
}