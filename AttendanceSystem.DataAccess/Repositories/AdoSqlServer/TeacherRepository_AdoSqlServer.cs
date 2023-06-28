using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using AttendanceSystem.Models.Ado_SqlServer;
using System.Data.SqlClient;

namespace AttendanceSystem.DataAccess.Repositories.AdoSqlServer;

public class TeacherRepository_AdoSqlServer :  ITeacherRepository
{
    public int Add(TeacherModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("INSERT INTO Teacher (FirstName, LastName, FatherName, BirthDate, TeacherID) VALUES (@FirstName, @LastName, @FatherName, @BirthDate, @TeacherID); SELECT SCOPE_IDENTITY();", connection);
        command.Parameters.AddWithValue("@FirstName", entity.FirstName);
        command.Parameters.AddWithValue("@LastName", entity.LastName);
        command.Parameters.AddWithValue("@FatherName", (object?)entity.FatherName ?? DBNull.Value);
        command.Parameters.AddWithValue("@BirthDate", (object?)entity.BirthDate ?? DBNull.Value);
        command.Parameters.AddWithValue("@TeacherID", entity.TeacherID);
        return Convert.ToInt32(command.ExecuteScalar());
    }

    public void Update(TeacherModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("UPDATE Teacher SET FirstName = @FirstName, LastName = @LastName, FatherName = @FatherName, BirthDate = @BirthDate WHERE TeacherID = @TeacherID", connection);
        command.Parameters.AddWithValue("@FirstName", entity.FirstName);
        command.Parameters.AddWithValue("@LastName", entity.LastName);
        command.Parameters.AddWithValue("@FatherName", (object?)entity.FatherName ?? DBNull.Value);
        command.Parameters.AddWithValue("@BirthDate", (object?)entity.BirthDate ?? DBNull.Value);
        command.Parameters.AddWithValue("@TeacherID", entity.TeacherID);
        command.ExecuteNonQuery();
    }

    public void Delete(TeacherModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("DELETE FROM Teacher WHERE TeacherID = @TeacherID", connection);
        command.Parameters.AddWithValue("@TeacherID", entity.TeacherID);
        command.ExecuteNonQuery();
    }

    public List<TeacherModel> GetAll()
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("SELECT * FROM Teacher", connection);
        using var reader = command.ExecuteReader();
        var result = new List<TeacherModel>();
        while (reader.Read())
            result.Add(new TeacherModel(
                reader.GetString(0),
                reader.GetString(1),
                reader.IsDBNull(2) ? null : reader.GetString(2),
                reader.IsDBNull(3) ? null : reader.GetDateTime(3),
                reader.GetInt32(4)));
        return result;
    }

    public TeacherModel? GetByID(int id)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("SELECT * FROM Teacher WHERE TeacherID = @TeacherID", connection);
        command.Parameters.AddWithValue("@TeacherID", id);
        using var reader = command.ExecuteReader();
        if (reader.Read())
            return new TeacherModel(
                reader.GetString(0),
                reader.GetString(1),
                reader.IsDBNull(2) ? null : reader.GetString(2),
                reader.IsDBNull(3) ? null : reader.GetDateTime(3),
                reader.GetInt32(4));
        return null;
    }
}
