using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oqtane.Demo31.Services
{
    public interface IDemoService
    {
        Task<Dictionary<string, object>> GetSystemInfoAsync();
        Task<List<Models.WeatherForecast>> GetWeatherForecastsAsync();
   }
}
