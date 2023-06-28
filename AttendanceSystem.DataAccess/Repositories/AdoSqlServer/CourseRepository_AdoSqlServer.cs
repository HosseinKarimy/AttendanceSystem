using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using AttendanceSystem.Models.Ado_SqlServer;
using System.Data.SqlClient;

namespace AttendanceSystem.DataAccess.Repositories.AdoSqlServer;

public class CourseRepository_AdoSqlServer : ICourseRepository
{
    public int Add(CourseModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("INSERT INTO Course (Name) VALUES (@Name); SELECT SCOPE_IDENTITY();", connection);
        command.Parameters.AddWithValue("@Name", entity.Name);
        return Convert.ToInt32(command.ExecuteScalar());
    }

    public void Update(CourseModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("UPDATE Course SET Name = @Name WHERE CourseID = @CourseID", connection);
        command.Parameters.AddWithValue("@Name", entity.Name);
        command.Parameters.AddWithValue("@CourseID", entity.CourseID);
        command.ExecuteNonQuery();
    }

    public void Delete(CourseModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("DELETE FROM Course WHERE CourseID = @CourseID", connection);
        command.Parameters.AddWithValue("@CourseID", entity.CourseID);
        command.ExecuteNonQuery();
    }

    public List<CourseModel> GetAll()
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("SELECT * FROM Course", connection);
        using var reader = command.ExecuteReader();
        var result = new List<CourseModel>();
        while (reader.Read())
            result.Add(new CourseModel(reader.GetInt32(0), reader.GetString(1)));
        return result;
    }

    public CourseModel? GetByID(int id)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("SELECT * FROM Course WHERE CourseID = @CourseID", connection);
        command.Parameters.AddWithValue("@CourseID", id);
        using var reader = command.ExecuteReader();
        if (reader.Read())
            return new CourseModel(reader.GetInt32(0), reader.GetString(1));
        return null;
    }
}
