using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using AttendanceSystem.Models.Ado_SqlServer;
using System.Data.SqlClient;

namespace AttendanceSystem.DataAccess.Repositories.AdoSqlServer;

public class DegreeRepository_AdoSqlServer : IDegreeRepository
{
    public int Add(DegreeModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("INSERT INTO Degree (Name) VALUES (@Name); SELECT SCOPE_IDENTITY();", connection);
        command.Parameters.AddWithValue("@Name", entity.Name);
        return Convert.ToInt32(command.ExecuteScalar());
    }

    public void Update(DegreeModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("UPDATE Degree SET Name = @Name WHERE DegreeID = @DegreeID", connection);
        command.Parameters.AddWithValue("@Name", entity.Name);
        command.Parameters.AddWithValue("@DegreeID", entity.DegreeID);
        command.ExecuteNonQuery();
    }

    public void Delete(DegreeModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("DELETE FROM Degree WHERE DegreeID = @DegreeID", connection);
        command.Parameters.AddWithValue("@DegreeID", entity.DegreeID);
        command.ExecuteNonQuery();
    }

    public List<DegreeModel> GetAll()
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("SELECT * FROM Degree", connection);
        using var reader = command.ExecuteReader();
        var result = new List<DegreeModel>();
        while (reader.Read())
            result.Add(new DegreeModel(reader.GetInt32(0), reader.GetString(1)));
        return result;
    }

    public int GetByID(int id)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("SELECT * FROM Degree WHERE DegreeID = @DegreeID", connection);
        command.Parameters.AddWithValue("@DegreeID", id);
        using var reader = command.ExecuteReader();
        if (reader.Read())
            return reader.GetInt32(0);
        return -1;
    }
}
