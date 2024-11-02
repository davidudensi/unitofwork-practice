using UnitOfWorkPractice.DataAccess.Models;

namespace UnitOfWorkPractice.API.Queries;

public static class CustomerQueries
{
    public static Func<IQueryable<Customer>, IEnumerable<int>> GetCustomerIdsQuery()
    {
        return customers => customers
            .Select(customer => customer.CustomerId);
    }

    public static Func<IQueryable<Customer>, Customer> GetCustomerQuery(int Id)
    {
        return customers => customers
            .Where(x => x.CustomerId == Id).FirstOrDefault();
    }
}
