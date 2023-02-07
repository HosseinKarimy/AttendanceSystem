using AttendanceSystem.DataAccess.Repositories.IRepositories;
using System.Linq.Expressions;

namespace AttendanceSystem.DataAccess.Repositories.AdoSqlServer;

public class Repository_AdoSqlServer<T> : IRepository<T> where T : class
{
    public void Add(T entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(T entity)
    {
        throw new NotImplementedException();
    }

    public T FirstOrDefault(Expression<Func<T, bool>> expression, string includes)
    {
        throw new NotImplementedException();
    }

    public T FirstOrDefault(Expression<Func<T, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public List<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public List<T> GetAll(string include)
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }
}
