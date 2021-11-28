using ExchangeRateApi.Models;
using ExchangeRateApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExchangeRateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangeRatesController : ControllerBase
    {
        //IExchangeRateService
        private IExchangeRateService _service;

        public ExchangeRatesController(IExchangeRateService service)
        {
            _service = service;
        }

        // GET: api/<ExchangeRatesController>
        [HttpGet]
        public async Task<ExchangeRateResponse> Get([FromQuery] HistoricalRateRequest request)
        {
            var response = await _service.GetRates(request);

            return response;
        }
    }
}
