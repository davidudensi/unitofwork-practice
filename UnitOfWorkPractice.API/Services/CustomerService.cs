using UnitOfWorkPractice.API.Models;
using UnitOfWorkPractice.API.Repositories;

namespace UnitOfWorkPractice.API.Services;

public class CustomerService : ICustomerService
{
    private readonly IUnitOfWork _unitOfWork;
    public CustomerService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IEnumerable<Customer> GetAllCustomers()
    {
        return _unitOfWork.Customers.GetAll();
    }

    public void CreateCustomer(Customer customer)
    {
        _unitOfWork.Customers.Add(customer);
        _unitOfWork.Complete();
    }
}