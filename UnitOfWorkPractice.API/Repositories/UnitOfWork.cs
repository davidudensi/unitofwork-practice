using UnitOfWorkPractice.API.Data;
using UnitOfWorkPractice.API.Models;

namespace UnitOfWorkPractice.API.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;
    public IRepository<Customer> Customers { get; }

    public IRepository<Order> Orders { get; }
    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        Customers = new Repository<Customer>(_context);
        Orders = new Repository<Order>(_context);
    }

    public int Complete()
    {
        return _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}