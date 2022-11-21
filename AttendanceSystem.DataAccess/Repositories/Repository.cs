using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

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

    public List<T> GetAll()
    {
        return DbSet.ToList();
    }

    public void Update(T entity)
    {
        DbSet.Update(entity);
    }
}
