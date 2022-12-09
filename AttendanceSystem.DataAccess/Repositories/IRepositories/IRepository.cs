using System.Linq.Expressions;

namespace AttendanceSystem.DataAccess.Repositories.IRepositories;

public interface IRepository<T>
{
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    List<T> GetAll();
    List<T> GetAll(string include);
    T FirstOrDefault(Expression<Func<T,bool>> expression,string includes);
    T FirstOrDefault(Expression<Func<T, bool>> expression);
}
