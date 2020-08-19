using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HandsOn.Api.Controllers
{
    [Route("api/divisor")]
    [ApiController]
    public class DivisorController : ControllerBase
    {
        public DivisorController()
        {

        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetDivisorsAndPrimesDivisors(int number)
        {
            return Ok();
        }
    }
}
