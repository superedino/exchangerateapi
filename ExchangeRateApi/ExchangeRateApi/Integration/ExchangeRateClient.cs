using ExchangeRateApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExchangeRateApi.Integration
{
    public interface IExchangeRateClient
    {
        Task<IEnumerable<HistoricalRateResponse>> GetHistoricalRatesForDate(List<string> dates, string baseCurrency);
    }

    public class ExchangeRateClient : IExchangeRateClient
    {
        private readonly HttpClient _httpClient;

        public ExchangeRateClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<HistoricalRateResponse>> GetHistoricalRatesForDate(List<string> dates, string baseCurrency)
        {
            var tasks = dates.Select(date => Task.Run(async () => await _httpClient.GetStringAsync($"/{date}?base={baseCurrency}")));
            var continuation = Task.WhenAll(tasks);

            await continuation;

            if (continuation.IsFaulted)
            {
                //TODO: log
                throw continuation.Exception;
            }

            return continuation.Result.Select(response => JsonConvert.DeserializeObject<HistoricalRateResponse>(response));
        }
    }
}
