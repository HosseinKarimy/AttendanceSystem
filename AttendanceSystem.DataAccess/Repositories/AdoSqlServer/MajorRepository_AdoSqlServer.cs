using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using AttendanceSystem.Models.Ado_SqlServer;
using System.Data.SqlClient;

namespace AttendanceSystem.DataAccess.Repositories.AdoSqlServer;

public class MajorRepository_AdoSqlServer : IMajorRepository
{
    public int Add(MajorModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("INSERT INTO Major (Name) VALUES (@Name); SELECT SCOPE_IDENTITY();", connection);
        command.Parameters.AddWithValue("@Name", entity.Name);
        return Convert.ToInt32(command.ExecuteScalar());
    }

    public void Update(MajorModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("UPDATE Major SET Name = @Name WHERE MajorID = @MajorID", connection);
        command.Parameters.AddWithValue("@Name", entity.Name);
        command.Parameters.AddWithValue("@MajorID", entity.MajorID);
        command.ExecuteNonQuery();
    }

    public void Delete(MajorModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("DELETE FROM Major WHERE MajorID = @MajorID", connection);
        command.Parameters.AddWithValue("@MajorID", entity.MajorID);
        command.ExecuteNonQuery();
    }

    public List<MajorModel> GetAll()
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("SELECT * FROM Major", connection);
        using var reader = command.ExecuteReader();
        var result = new List<MajorModel>();
        while (reader.Read())
            result.Add(new MajorModel(reader.GetInt32(0), reader.GetString(1)));
        return result;
    }

    public MajorModel? GetByID(int id)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("SELECT * FROM Major WHERE MajorID = @MajorID", connection);
        command.Parameters.AddWithValue("@MajorID", id);
        using var reader = command.ExecuteReader();
        if (reader.Read())
            return new MajorModel(reader.GetInt32(0), reader.GetString(1));
        return null;
    }
}
