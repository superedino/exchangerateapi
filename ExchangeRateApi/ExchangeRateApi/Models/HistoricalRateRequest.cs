using System.Collections.Generic;

namespace ExchangeRateApi.Models
{
    public class HistoricalRateRequest
    {
        public List<string> Dates { get; set; }

        public string SymbolCurrency { get; set; }

        public string BaseCurrency { get; set; }
    }
}
