using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOn.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HandsOn.Api.Controllers
{
    [Route("api/divisor")]
    public class DivisorController : ControllerBase
    {
        public IDivisorService _divisorService;
        public DivisorController(IDivisorService divisorService)
        {
            _divisorService = divisorService;
        }

        [HttpGet, Route("")]
        public async Task<IActionResult> GetDivisorsAndPrimesDivisors(int number)
        {
            var result = await _divisorService.CalculateDivisors(number);

            return Ok(result);
        }
    }
}
