using Microsoft.EntityFrameworkCore;
using UnitOfWorkPractice.DataAccess.Models;

namespace UnitOfWorkPractice.DataAccess.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
}