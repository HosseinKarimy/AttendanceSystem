using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AttendanceSystem.DataAccess.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly DbSet<T> DbSet;
    public Repository(AppDbContext dbContext)
    {
        DbSet = dbContext.Set<T>();
    }

    public void Add(T entity)
    {
        DbSet.Add(entity);
    }

    public void Delete(T entity)
    {
        DbSet.Remove(entity);
    }

    public T FirstOrDefault(Expression<Func<T, bool>> expression, string includes)
    {
        return DbSet.Include(includes).FirstOrDefault(expression);
    }

    public T FirstOrDefault(Expression<Func<T, bool>> expression)
    {
        return DbSet.FirstOrDefault(expression);
    }

    public List<T> GetAll()
    {
        return DbSet.ToList();
    }

    public List<T> GetAll(string include)
    {
        return DbSet.Include(include).ToList();
    }

    public void Update(T entity)
    {
        DbSet.Update(entity);
    }

}
