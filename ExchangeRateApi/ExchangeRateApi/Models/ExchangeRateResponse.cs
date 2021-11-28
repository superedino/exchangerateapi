using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeRateApi.Models
{
    public class ExchangeRateResponse
    {
        public Rate MinRate { get; set; }
        public Rate MaxRate { get; set; }
        public decimal AverageRate { get; set; }
        public string BaseCurrency { get; set; }
        public string ConversionCurrency { get; set; }

        public ExchangeRateResponse() {}

        public ExchangeRateResponse(Rate min, Rate max, decimal average, string baseCurrency, string conversionCurrency)
        {
            MinRate = min;
            MaxRate = max;
            AverageRate = average;
            BaseCurrency = baseCurrency;
            ConversionCurrency = conversionCurrency;
        }
    }

    public class Rate
    {
        public string Date { get; set; }
        public decimal Value { get; set; }

        public Rate() {}

        public Rate(string date, decimal value)
        {
            Date = date;
            Value = value;
        }
    }
}
