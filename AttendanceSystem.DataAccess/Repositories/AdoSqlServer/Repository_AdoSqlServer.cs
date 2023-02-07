using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Models.Models;
using System.Linq.Expressions;

namespace AttendanceSystem.DataAccess.Repositories.AdoSqlServer;

public class Repository_AdoSqlServer<T> : IRepository<T> where T : class
{
    private readonly DbSet<T> DbSet;
    public Repository_AdoSqlServer(AppDbContext dbContext)
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
        var Includes = includes.Split('\u002C');
        foreach (string include in Includes)
        {
            DbSet.Include(include.Trim()).Load();
        }
        return DbSet.FirstOrDefault(expression);

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
