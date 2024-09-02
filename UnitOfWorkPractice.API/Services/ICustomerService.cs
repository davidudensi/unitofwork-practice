using UnitOfWorkPractice.API.Models;

namespace UnitOfWorkPractice.API.Services;

public interface ICustomerService
{
    public IEnumerable<Customer> GetAllCustomers();
    public void CreateCustomer(Customer customer);
}