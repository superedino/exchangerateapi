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

        public ExchangeRateResponse(Rate min, Rate max, decimal average)
        {
            MinRate = min;
            MaxRate = max;
            AverageRate = average;
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
