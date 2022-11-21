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
        throw new NotImplementedException();
    }

    public void Delete(T entity)
    {
        throw new NotImplementedException();
    }

    public List<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }
}
