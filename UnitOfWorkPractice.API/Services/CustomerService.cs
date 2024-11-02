using UnitOfWorkPractice.API.Queries;
using UnitOfWorkPractice.DataAccess.Models;
using UnitOfWorkPractice.DataAccess.Repositories;

namespace UnitOfWorkPractice.API.Services;

public class CustomerService : ICustomerService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRepository<Customer> _customers;
    public CustomerService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        _customers = _unitOfWork.Customers;
    }

    public IEnumerable<Customer> GetAllCustomers()
    {
        return _customers.GetAll();
    }

    public void CreateCustomer(Customer customer)
    {
        _customers.Add(customer);
        _unitOfWork.Complete();
    }

    public Customer GetCustomer(int Id)
    {
        var customer = _customers.Find(CustomerQueries.GetCustomerQuery(Id));
        return customer;
    }

    public async Task<IEnumerable<int>> GetCustomerIds()
    {
        var customerIds = await _customers.Find(CustomerQueries.GetCustomerIdsQuery());
        return customerIds;
    }
}