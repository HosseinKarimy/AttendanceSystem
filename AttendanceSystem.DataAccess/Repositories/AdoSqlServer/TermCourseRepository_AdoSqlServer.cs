using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using AttendanceSystem.Models.Ado_SqlServer;
using System.Data.SqlClient;

namespace AttendanceSystem.DataAccess.Repositories.AdoSqlServer;

public class TermCourseRepository_AdoSqlServer : ITermCourseRepository
{
    public int Add(TermCourseModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("INSERT INTO TermCourse (MidTermExamDate, FinalExamDate, CourseID, TermID, TeacherID) VALUES (@MidTermExamDate, @FinalExamDate, @CourseID, @TermID, @TeacherID); SELECT SCOPE_IDENTITY();", connection);
        command.Parameters.AddWithValue("@MidTermExamDate", (object?)entity.MidTermExamDate ?? DBNull.Value);
        command.Parameters.AddWithValue("@FinalExamDate", (object?)entity.FinalExamDate ?? DBNull.Value);
        command.Parameters.AddWithValue("@CourseID", entity.CourseID);
        command.Parameters.AddWithValue("@TermID", entity.TermID);
        command.Parameters.AddWithValue("@TeacherID", entity.TeacherID);
        return Convert.ToInt32(command.ExecuteScalar());
    }

    public void Update(TermCourseModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("UPDATE TermCourse SET MidTermExamDate = @MidTermExamDate, FinalExamDate = @FinalExamDate WHERE TermCourseID = @TermCourseID", connection);
        command.Parameters.AddWithValue("@MidTermExamDate", (object?)entity.MidTermExamDate ?? DBNull.Value);
        command.Parameters.AddWithValue("@FinalExamDate", (object?)entity.FinalExamDate ?? DBNull.Value);
        command.Parameters.AddWithValue("@TermCourseID", entity.TermCourseID);
        command.ExecuteNonQuery();
    }

    public void Delete(TermCourseModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("DELETE FROM TermCourse WHERE TermCourseID = @TermCourseID", connection);
        command.Parameters.AddWithValue("@TermCourseID", entity.TermCourseID);
        command.ExecuteNonQuery();
    }

    public List<TermCourseModel> GetAll()
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("SELECT * FROM TermCourse", connection);
        using var reader = command.ExecuteReader();
        var result = new List<TermCourseModel>();
        while (reader.Read())
            result.Add(new TermCourseModel(
                reader.GetInt32(0),
                reader.IsDBNull(1) ? null : reader.GetDateTime(1),
                reader.IsDBNull(2) ? null : reader.GetDateTime(2),
                reader.GetInt32(3),
                reader.GetInt32(4),
                reader.GetInt32(5)));
        return result;
    }

    public int GetByID(int id)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("SELECT * FROM TermCourse WHERE TermCourseID = @TermCourseID", connection);
        command.Parameters.AddWithValue("@TermCourseID", id);
        using var reader = command.ExecuteReader();
        if (reader.Read())
            return reader.GetInt32(0);
        return -1;
    }
}
