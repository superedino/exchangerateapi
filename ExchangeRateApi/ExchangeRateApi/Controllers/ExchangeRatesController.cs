using ExchangeRateApi.Models;
using ExchangeRateApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExchangeRateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangeRatesController : ControllerBase
    {
        private IExchangeRateService _service;

        public ExchangeRatesController(IExchangeRateService service)
        {
            _service = service;
        }

        // GET: api/<ExchangeRatesController>
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] ExchangeRateRequest request)
        {
            //TODO: Validate request
            try
            {
                var response = await _service.GetRates(request);

                return Ok(response);
            }
            catch(Exception e)
            {
                //log error
                return StatusCode(500, e.Message);
            }
        }
    }
}
