using Microsoft.AspNetCore.Mvc;

namespace UnitOfWorkPractice.API2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookingController : ControllerBase
{
    [HttpGet("ping", Name = "Welcome")]
    public IActionResult Get()
    {
        return Ok("Welcome to Unit of Work Practice - Booking");
    }
}
