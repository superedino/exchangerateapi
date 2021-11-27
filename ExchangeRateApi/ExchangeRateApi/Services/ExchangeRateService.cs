using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExchangeRateApi.Services
{
    public class ExchangeRateService : IExchangeRateService
    {
        private readonly HttpClient _httpClient;

        public ExchangeRateService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task GetRate()
        {
            var responseString = await _httpClient.GetStringAsync("https://api.exchangerate.host/2020-04-04");
            ;
            //var catalog = JsonConvert.DeserializeObject<Catalog>(responseString);
            //return catalog;
        }
    }
}
