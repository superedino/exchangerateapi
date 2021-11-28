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

        public async Task<ExchangeRateResponse> GetRates(ExchangeRateRequest request)
        {
            var historicalRates = await _integrationClient.GetHistoricalRatesForDate(request.Dates, request.BaseCurrency);

            if (historicalRates == null || historicalRates.Count() == 0)
            {
                throw new Exception("Error, failed to load data!");
            }

            return GenerateResponse(historicalRates, request);
        }

        private ExchangeRateResponse GenerateResponse(IEnumerable<HistoricalRateResponse> historicalRates, ExchangeRateRequest request)
        {
            var response = new ExchangeRateResponse();
            decimal sumOfValidRates = 0;
            int numberOfValidRates = 0;

            foreach (var historicalRate in historicalRates)
            {
                if (!historicalRate.Success || !request.Dates.Contains(historicalRate.Date))
                {
                    continue;
                }

                decimal currentRateValue = 0;
                string selectedCurrency = request.SymbolCurrency;

                try
                {
                    currentRateValue = GetRateForSelectedCurrency(historicalRate.Rates, selectedCurrency);
                }
                catch (ArgumentNullException e)
                {
                    //TODO: Get default currency from AppSettings
                    currentRateValue = historicalRate.Rates.SEK;
                    selectedCurrency = $"{nameof(historicalRate.Rates.SEK)} (default)";
                }

                if (sumOfValidRates == 0)
                {
                    InitResponse(response, request, historicalRate, currentRateValue, selectedCurrency);
                }
                else
                {
                    UpdateResponseMinMaxRates(response, historicalRate, currentRateValue);
                }

                sumOfValidRates = sumOfValidRates + currentRateValue;
                numberOfValidRates++;
            }

            response.AverageRate = sumOfValidRates / numberOfValidRates;

            return response;
        }
        
        private decimal GetRateForSelectedCurrency(Rates allRates, string selectedCurrency)
        {
            var convertedValueProperty = allRates.GetType().GetProperty(selectedCurrency).GetValue(allRates);
            
            return decimal.Parse(convertedValueProperty.ToString());
        }

        private void InitResponse(ExchangeRateResponse response, ExchangeRateRequest request, HistoricalRateResponse historicalRate, decimal currentRateValue, string selectedCurrency)
        {
            response.MinRate = new Rate(historicalRate.Date, currentRateValue);
            response.MaxRate = new Rate(historicalRate.Date, currentRateValue);

            response.ConversionCurrency = selectedCurrency;
            response.BaseCurrency = request.BaseCurrency == historicalRate.Base
                ? historicalRate.Base : $"{historicalRate.Base} (default)";
        }

        private void UpdateResponseMinMaxRates(ExchangeRateResponse response, HistoricalRateResponse historicalRate, decimal currentRateValue)
        {
            if (currentRateValue < response.MinRate.Value)
            {
                response.MinRate = new Rate(historicalRate.Date, currentRateValue);
            }

            if (currentRateValue > response.MaxRate.Value)
            {
                response.MaxRate = new Rate(historicalRate.Date, currentRateValue);
            }
        }
    }
}
