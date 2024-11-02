using UnitOfWorkPractice.DataAccess.Models;

namespace UnitOfWorkPractice.API.Services;

public interface ICustomerService
{
    public IEnumerable<Customer> GetAllCustomers();
    public void CreateCustomer(Customer customer);
    public Customer GetCustomer(int Id);
    public Task<IEnumerable<int>> GetCustomerIds();
}