namespace AttendanceSystem.DataAccess.Repositories.IRepositories;

public interface IRepository<T>
{
    int Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    List<T> GetAll();
    int GetByID(int id);
}
