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
        public async Task<IEnumerable<HistoricalRateResponse>> Get([FromQuery] HistoricalRateRequest request)
        {
            var response = await _service.GetRates(request);

            return response;
        }

        // GET api/<ExchangeRatesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ExchangeRatesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ExchangeRatesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ExchangeRatesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
