using System;
using System.Collections.Generic;
using PizaService.Core;
using PizaService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PizaService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       

       

        [HttpGet]
        public IEnumerable<Result> Get()
        {
            return BaseOperations.Toppings();
        }
    }
}
