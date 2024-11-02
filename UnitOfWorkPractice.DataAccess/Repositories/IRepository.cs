namespace UnitOfWorkPractice.DataAccess.Repositories;

public interface IRepository<T> where T : class
{
    IEnumerable<T> GetAll();
    T? GetById(int id);
    T? Find(Func<IQueryable<T>, T> query);
    Task<IEnumerable<int>> Find(Func<IQueryable<T>, IEnumerable<int>> query);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}