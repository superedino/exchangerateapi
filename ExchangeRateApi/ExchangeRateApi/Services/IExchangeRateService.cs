using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeRateApi.Services
{
    public interface IExchangeRateService
    {
        Task GetRate();
    }
}
