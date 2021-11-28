using ExchangeRateApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExchangeRateApi.Services
{
    public interface IExchangeRateService
    {
        Task<ExchangeRateResponse> GetRates(HistoricalRateRequest request);
    }
}
