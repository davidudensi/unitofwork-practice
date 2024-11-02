using Microsoft.AspNetCore.Mvc;

namespace UnitOfWorkPractice.Launch.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LaunchController : ControllerBase
{
    [HttpGet("ping", Name = "LaunchWelcome")]
    public IActionResult Get()
    {
        return Ok("Welcome to Unit of Work Practice - Launch");
    }
}
