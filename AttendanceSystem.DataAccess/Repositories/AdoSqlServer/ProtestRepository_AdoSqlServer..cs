using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using AttendanceSystem.Models.Ado_SqlServer;
using System.Data.SqlClient;

namespace AttendanceSystem.DataAccess.Repositories.AdoSqlServer;

public class ProtestRepository : IProtestRepository
{
    public int Add(ProtestModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("INSERT INTO Protest (Result, Status, Description, StudentStatusID) VALUES (@Result, @Status, @Description, @StudentStatusID); SELECT SCOPE_IDENTITY();", connection);
        command.Parameters.AddWithValue("@Result", (object?)entity.Result ?? DBNull.Value);
        command.Parameters.AddWithValue("@Status", (object?)entity.Status ?? DBNull.Value);
        command.Parameters.AddWithValue("@Description", (object?)entity.Description ?? DBNull.Value);
        command.Parameters.AddWithValue("@StudentStatusID", entity.StudentStatusID);
        return Convert.ToInt32(command.ExecuteScalar());
    }

    public void Update(ProtestModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("UPDATE Protest SET Result = @Result, Status = @Status, Description = @Description WHERE StudentStatusID = @StudentStatusID", connection);
        command.Parameters.AddWithValue("@Result", (object?)entity.Result ?? DBNull.Value);
        command.Parameters.AddWithValue("@Status", (object?)entity.Status ?? DBNull.Value);
        command.Parameters.AddWithValue("@Description", (object?)entity.Description ?? DBNull.Value);
        command.Parameters.AddWithValue("@StudentStatusID", entity.StudentStatusID);
        command.ExecuteNonQuery();
    }

    public void Delete(ProtestModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("DELETE FROM Protest WHERE StudentStatusID = @StudentStatusID", connection);
        command.Parameters.AddWithValue("@StudentStatusID", entity.StudentStatusID);
        command.ExecuteNonQuery();
    }

    public List<ProtestModel> GetAll()
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("SELECT * FROM Protest", connection);
        using var reader = command.ExecuteReader();
        var result = new List<ProtestModel>();
        while (reader.Read())
            result.Add(new ProtestModel(
                reader.IsDBNull(0) ? null : reader.GetInt32(0),
                reader.IsDBNull(1) ? null : reader.GetInt32(1),
                reader.IsDBNull(2) ? null : reader.GetString(2),
                reader.GetInt32(3)));
        return result;
    }

    public ProtestModel? GetByID(int id)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("SELECT * FROM Protest WHERE StudentStatusID = @StudentStatusID", connection);
        command.Parameters.AddWithValue("@StudentStatusID", id);
        using var reader = command.ExecuteReader();
        if (reader.Read())
            return new ProtestModel(
                reader.IsDBNull(0) ? null : reader.GetInt32(0),
                reader.IsDBNull(1) ? null : reader.GetInt32(1),
                reader.IsDBNull(2) ? null : reader.GetString(2),
                reader.GetInt32(3));
        return null;
    }
}
