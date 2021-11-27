using System.Collections.Generic;

namespace ExchangeRateApi.Models
{
    public class HistoricalRateRequest
    {
        public List<string> Dates { get; set; }

        public List<string> SymbolCurrencies { get; set; }

        public string BaseCurrency { get; set; }
    }
}
