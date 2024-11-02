using Microsoft.EntityFrameworkCore;
using UnitOfWorkPractice.DataAccess.Data;

namespace UnitOfWorkPractice.DataAccess.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly ApplicationDbContext _context;
    private readonly DbSet<T> _dbSet;
    public Repository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }
    public void Add(T entity)
    {
        _dbSet.Add(entity);
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
    }

    public T? Find(Func<IQueryable<T>, T> query)
    {
        return query(_dbSet);
    }

    public async Task<IEnumerable<int>> Find(Func<IQueryable<T>, IEnumerable<int>> query)
    {
        return await Task.FromResult(query(_dbSet));
    }

    public IEnumerable<T> GetAll()
    {
        return _dbSet.ToList();
    }

    public T? GetById(int id)
    {
        return _dbSet.Find(id);
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
    }
}