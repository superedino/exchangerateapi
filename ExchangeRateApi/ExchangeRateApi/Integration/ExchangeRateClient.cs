using ExchangeRateApi.Models;
using Newtonsoft.Json;
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
            var responseString2 = await _httpClient.GetStringAsync($"/timeseries?start_date=2020-01-01&end_date=2021-01-04");

            //var tasks = dates.Select(date => Task.Run(async () => await _httpClient.GetStringAsync($"/{date}?base={baseCurrency}&symbols={string.Join(",", symbolCurrencies)}")));
            var tasks = dates.Select(date => Task.Run(async () => await _httpClient.GetStringAsync($"/{date}?base={baseCurrency}")));
            var continuation = Task.WhenAll(tasks);

            await continuation;

            if (continuation.IsFaulted)
            {
                throw continuation.Exception;
            }

            return continuation.Result.Select(response => JsonConvert.DeserializeObject<HistoricalRateResponse>(response));
        }
    }
}
