using Microsoft.AspNetCore.Mvc;
using UnitOfWorkPractice.API.Models;
using UnitOfWorkPractice.API.Services;

namespace UnitOfWorkPractice.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ICustomerService _customerService;
    public CustomerController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpGet(Name = "GetAllCustomers")]
    public IActionResult Get()
    {
        var customers = _customerService.GetAllCustomers();
        return Ok(customers);
    }

    [HttpPost]
    public IActionResult CreateCustomer([FromBody] Customer customer)
    {
        _customerService.CreateCustomer(customer);
        return Ok("Customer add successfully");
    }
}
