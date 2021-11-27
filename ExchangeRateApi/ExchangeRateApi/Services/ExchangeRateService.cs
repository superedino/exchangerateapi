using ExchangeRateApi.Models;
using Newtonsoft.Json;
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

        public async Task<IEnumerable<HistoricalRateResponse>> GetRates(HistoricalRateRequest request)
        {
            var tasks = request.Dates.Select(date => Task.Run(async () => await _httpClient.GetStringAsync($"/{date}?base={request.BaseCurrency}&symbols={string.Join(",", request.SymbolCurrencies)}")));
            var continuation = Task.WhenAll(tasks);

            await continuation;

            if (continuation.IsFaulted)
            {
                throw continuation.Exception;
            }

            return continuation.Result.Select(response => JsonConvert.DeserializeObject<HistoricalRateResponse>(response));
        }

        public async Task GetRate()
        {
            //var responseString = await _httpClient.GetStringAsync("https://api.exchangerate.host/2020-04-04?symbols=USD,EUR");
            var responseString = await _httpClient.GetStringAsync("/2020-04-04");

            var historicalRate = JsonConvert.DeserializeObject<HistoricalRateResponse>(responseString);
            ;
            //var catalog = JsonConvert.DeserializeObject<Catalog>(responseString);
            //return catalog;
        }
    }
}
