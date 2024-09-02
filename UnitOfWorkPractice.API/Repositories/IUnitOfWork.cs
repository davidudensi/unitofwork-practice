using UnitOfWorkPractice.API.Models;

namespace UnitOfWorkPractice.API.Repositories;

public interface IUnitOfWork : IDisposable
{
    IRepository<Customer> Customers { get; }
    IRepository<Order> Orders { get; }
    int Complete();
}