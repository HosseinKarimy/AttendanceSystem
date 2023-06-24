using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using AttendanceSystem.Models.Ado_SqlServer;
using System.Data.SqlClient;

namespace AttendanceSystem.DataAccess.Repositories.AdoSqlServer;

public class SectionRepository_AdoSqlServer : ISectionRepository
{
    public int Add(SectionModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("INSERT INTO Section (SectionNumber, Duration, StartTime, Day, Date, TermCourseID) VALUES (@SectionNumber, @Duration, @StartTime, @Day, @Date, @TermCourseID); SELECT SCOPE_IDENTITY();", connection);
        command.Parameters.AddWithValue("@SectionNumber", (object?)entity.SectionNumber ?? DBNull.Value);
        command.Parameters.AddWithValue("@Duration", (object?)entity.Duration ?? DBNull.Value);
        command.Parameters.AddWithValue("@StartTime", (object?)entity.StartTime ?? DBNull.Value);
        command.Parameters.AddWithValue("@Day", (object?)entity.Day ?? DBNull.Value);
        command.Parameters.AddWithValue("@Date", (object?)entity.Date ?? DBNull.Value);
        command.Parameters.AddWithValue("@TermCourseID", entity.TermCourseID);
        return Convert.ToInt32(command.ExecuteScalar());
    }

    public void Update(SectionModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("UPDATE Section SET SectionNumber = @SectionNumber, Duration = @Duration, StartTime = @StartTime, Day = @Day, Date = @Date WHERE SectionID = @SectionID", connection);
        command.Parameters.AddWithValue("@SectionNumber", (object?)entity.SectionNumber ?? DBNull.Value);
        command.Parameters.AddWithValue("@Duration", (object?)entity.Duration ?? DBNull.Value);
        command.Parameters.AddWithValue("@StartTime", (object?)entity.StartTime ?? DBNull.Value);
        command.Parameters.AddWithValue("@Day", (object?)entity.Day ?? DBNull.Value);
        command.Parameters.AddWithValue("@Date", (object?)entity.Date ?? DBNull.Value);
        command.Parameters.AddWithValue("@SectionID", entity.SectionID);
        command.ExecuteNonQuery();
    }

    public void Delete(SectionModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("DELETE FROM Section WHERE SectionID = @SectionID", connection);
        command.Parameters.AddWithValue("@SectionID", entity.SectionID);
        command.ExecuteNonQuery();
    }

    public List<SectionModel> GetAll()
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("SELECT * FROM Section", connection);
        using var reader = command.ExecuteReader();
        var result = new List<SectionModel>();
        while (reader.Read())
            result.Add(new SectionModel(
                reader.GetInt32(0),
                reader.IsDBNull(1) ? null : reader.GetInt32(1),
                reader.IsDBNull(2) ? null : reader.GetInt32(2),
                reader.IsDBNull(3) ? null : reader.GetTimeSpan(3),
                reader.IsDBNull(4) ? null : reader.GetDateTime(4),
                reader.IsDBNull(5) ? null : reader.GetDateTime(5),
                reader.GetInt32(6)));
        return result;
    }

    public int GetByID(int id)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("SELECT * FROM Section WHERE SectionID = @SectionID", connection);
        command.Parameters.AddWithValue("@SectionID", id);
        using var reader = command.ExecuteReader();
        if (reader.Read())
            return reader.GetInt32(0);
        return -1;
    }
}
