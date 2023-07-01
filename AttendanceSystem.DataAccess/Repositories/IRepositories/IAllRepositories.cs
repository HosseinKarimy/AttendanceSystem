using System.Data;

namespace AttendanceSystem.DataAccess.Repositories.IRepositories;

public interface IAllRepositories
{
    public DataTable GetSomeDataFromTable(string tableName, string orderBy, string searchBy, string searchString, int offset, int fetchCount);
}
