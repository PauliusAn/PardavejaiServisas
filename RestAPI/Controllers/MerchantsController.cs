using System;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MerchantsController : ControllerBase
    {
        private readonly IMerchantService _merchantService;

        public MerchantsController(IMerchantService merchantService)
        {
            _merchantService = merchantService;
        }

        [HttpPost]
        [Route("payments")]
        public async Task<IActionResult> AddPayment([FromBody] Payment request)
        {
            await _merchantService.AddPayment(request);

            return Ok();
        }

        [HttpDelete]
        [Route("payments/{id:Guid}")]
        public async Task<IActionResult> DeletePayment(Guid id)
        {
            await _merchantService.DeletePayment(id);

            return Ok();
        }
    }
}
