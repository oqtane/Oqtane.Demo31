using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Oqtane.Modules;
using Oqtane.Services;
using Oqtane.Shared;

namespace Oqtane.Demo31.Services
{
    public class DemoService : RemoteServiceBase, IDemoService, IService
    {
        public DemoService(IHttpClientFactory httpClientFactory, SiteState siteState) : base(httpClientFactory, siteState) { }

        public async Task<Dictionary<string, object>> GetSystemInfoAsync()
        {
            return await GetJsonAsync<Dictionary<string, object>>("http://localhost:44357/api/system/?type=environment");
        }

        public async Task<List<Models.WeatherForecast>> GetWeatherForecastsAsync()
        {
            return await GetJsonAsync<List<Models.WeatherForecast>>("https://localhost:7119/weatherforecast");
        }
    }
}
