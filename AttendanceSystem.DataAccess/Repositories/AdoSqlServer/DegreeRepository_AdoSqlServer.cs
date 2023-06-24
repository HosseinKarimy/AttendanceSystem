using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using AttendanceSystem.Models.Ado_SqlServer;
using System.Data.SqlClient;

namespace AttendanceSystem.DataAccess.Repositories.AdoSqlServer;

public class DegreeRepository_AdoSqlServer : IDegreeRepository
{
    public void Add(DegreeModel entity)
    {
        using var sqlConnection = DbConnection.SqlConnection;
        SqlCommand cmd = new("insert into Degree Values(@DegreeName)", sqlConnection);
        cmd.Parameters.AddWithValue("@DegreeName", entity.Name);
        _ = cmd.ExecuteNonQuery();
    }

    public void Delete(DegreeModel entity)
    {
        throw new NotImplementedException();
    }

    public List<DegreeModel> GetAll()
    {
        throw new NotImplementedException();
    }

    public void Update(DegreeModel entity)
    {
        throw new NotImplementedException();
    }
}
