using Microsoft.AspNetCore.Mvc;
using PaymentStats.Api.Services.Interfaces;

namespace PaymentStats.Api.Controllers;

[ApiController]
[Route("api/payments")]
public class PaymentStatsController : ControllerBase
{
    private readonly IPaymentStatsService _service;

    public PaymentStatsController(IPaymentStatsService service)
    {
        _service = service;
    }

    [HttpGet("stats")]
    public IActionResult GetStats([FromQuery] string? currency = null)
    {
        try
        {
            return Ok(_service.Calculate(currency));
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("list")]
    public IActionResult GetListPayments([FromQuery] string? currency = null)
    {
        try
        {
            return Ok(_service.GetPaymentStatsList(currency));
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
