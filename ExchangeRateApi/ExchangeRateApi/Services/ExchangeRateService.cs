using ExchangeRateApi.Integration;
using ExchangeRateApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExchangeRateApi.Services
{
    public class ExchangeRateService : IExchangeRateService
    {
        private readonly IExchangeRateClient _integrationClient;

        public ExchangeRateService(IExchangeRateClient integrationClient)
        {
            _integrationClient = integrationClient;
        }

        public async Task<ExchangeRateResponse> GetRates(HistoricalRateRequest request)
        {
            //var test = DateTime.ParseExact("2012-04-05", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            //var dates = request.Dates;
            //dates.Sort((d1, d2) => DateTime.Compare(DateTime.ParseExact(d1, "yyyy-MM-dd", CultureInfo.InvariantCulture), DateTime.ParseExact(d2, "yyyy-MM-dd", CultureInfo.InvariantCulture)));
            //var responseString = await _httpClient.GetStringAsync("https://api.exchangerate.host/timeseries?start_date=2018-01-01&end_date=2020-01-04");
            //var testo = DateTime.ParseExact(dates.Last(), "yyyy-MM-dd", CultureInfo.InvariantCulture) - DateTime.ParseExact(dates.First(), "yyyy-MM-dd", CultureInfo.InvariantCulture);

            //var daysSpans = new List<List<string>>();
            //daysSpans.Add(new List<string>());
            //int index = 0;
            //foreach (var date in dates)
            //{
            //    if(daysSpans.Last().Count == 0)
            //    {
            //        daysSpans.Last().Add(date);
            //    }
            //    else if ((DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture) - DateTime.ParseExact(daysSpans.Last().First(), "yyyy-MM-dd", CultureInfo.InvariantCulture)).TotalDays <= 366)
            //    {
            //        daysSpans.Last().Add(date);
            //    }
            //    else
            //    {
            //        daysSpans.Add(new List<string>());
            //        daysSpans.Last().Add(date);
            //    }
            //}

            //var singleDates = new List<string>();
            //var dateSpans = new List<List<string>>();
            //foreach (var span in daysSpans)
            //{
            //    if (span.Count == 1)
            //    {
            //        singleDates.Add(span.First());
            //    }
            //    else
            //    {
            //        var span2 = new List<string>();
            //        span2.Add(span.First());
            //        span2.Add(span.Last());
            //        dateSpans.Add(span2);
            //    }
            //}

            

            var historicalRates = await _integrationClient.GetHistoricalRatesForDate(request.Dates, request.BaseCurrency);

            Rate minRate = new Rate();
            Rate maxRate = new Rate();
            decimal sum = 0;

            foreach (var historicalRate in historicalRates)
            {
                var rate = decimal.Parse((historicalRate.rates.GetType().GetProperty(request.SymbolCurrency).GetValue(historicalRate.rates)).ToString());
                
                if (sum == 0)
                {
                    minRate = new Rate(historicalRate.date, rate);
                    maxRate = new Rate(historicalRate.date, rate);
                }
                else
                {
                    if (rate < minRate.Value)
                    {
                        minRate = new Rate(historicalRate.date, rate);
                    }

                    if (rate > maxRate.Value)
                    {
                        maxRate = new Rate(historicalRate.date, rate);
                    }
                }

                sum = sum + rate;
            }

            var result = new ExchangeRateResponse(minRate, maxRate, sum/historicalRates.Count());

            return result;
        }
    }
}
