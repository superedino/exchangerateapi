using ExchangeRateApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExchangeRateApi.Services
{
    public interface IExchangeRateService
    {
        Task GetRate();

        Task<IEnumerable<HistoricalRateResponse>> GetRates(HistoricalRateRequest request);
    }
}
