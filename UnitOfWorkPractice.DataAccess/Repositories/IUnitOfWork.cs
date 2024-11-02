using UnitOfWorkPractice.DataAccess.Models;

namespace UnitOfWorkPractice.DataAccess.Repositories;

public interface IUnitOfWork : IDisposable
{
    IRepository<Customer> Customers { get; }
    IRepository<Order> Orders { get; }
    int Complete();
}