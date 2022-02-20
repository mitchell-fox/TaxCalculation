using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TaxCalculation.WebAPI.Settings;

namespace TaxCalculation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxJarCalculatorController : ControllerBase
    {
        private readonly IOptions<TaxJarApiOptions> options;

        public TaxJarCalculatorController(IOptions<TaxJarApiOptions> options)
        {
            this.options = options;
        }

        [HttpGet]
        public IActionResult Get()
        {

        }
    }
}
