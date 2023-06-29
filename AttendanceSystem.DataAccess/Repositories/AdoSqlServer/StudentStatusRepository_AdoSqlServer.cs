using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Models.Ado_SqlServer.Views;
using System.Data;
using System.Data.SqlClient;

namespace AttendanceSystem.DataAccess.Repositories.AdoSqlServer;

public class StudentStatusRepository_AdoSqlServer : IStudentStatusRepository
{
    public int Add(StudentStatusModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("INSERT INTO StudentStatus (IsPresent, Description, SectionID, StudentID) VALUES (@IsPresent, @Description, @SectionID, @StudentID); SELECT SCOPE_IDENTITY();", connection);
        command.Parameters.AddWithValue("@IsPresent", (object?)entity.IsPresent ?? DBNull.Value);
        command.Parameters.AddWithValue("@Description", (object?)entity.Description ?? DBNull.Value);
        command.Parameters.AddWithValue("@SectionID", entity.SectionID);
        command.Parameters.AddWithValue("@StudentID", entity.StudentID);
        return Convert.ToInt32(command.ExecuteScalar());
    }

    public void Update(StudentStatusModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("UPDATE StudentStatus SET IsPresent = @IsPresent, Description = @Description WHERE StudentStatusID = @StudentStatusID", connection);
        command.Parameters.AddWithValue("@IsPresent", (object?)entity.IsPresent ?? DBNull.Value);
        command.Parameters.AddWithValue("@Description", (object?)entity.Description ?? DBNull.Value);
        command.Parameters.AddWithValue("@StudentStatusID", entity.StudentStatusID);
        command.ExecuteNonQuery();
    }

    public void Delete(StudentStatusModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("DELETE FROM StudentStatus WHERE StudentStatusID = @StudentStatusID", connection);
        command.Parameters.AddWithValue("@StudentStatusID", entity.StudentStatusID);
        command.ExecuteNonQuery();
    }

    public List<StudentStatusModel> GetAll()
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("SELECT * FROM StudentStatus", connection);
        using var reader = command.ExecuteReader();
        var result = new List<StudentStatusModel>();
        while (reader.Read())
            result.Add(new StudentStatusModel(
                reader.GetInt32(0),
                reader.IsDBNull(1) ? null : reader.GetBoolean(1),
                reader.IsDBNull(2) ? null : reader.GetString(2),
                reader.GetInt32(3),
                reader.GetInt32(4)));
        return result;
    }

    public StudentStatusModel? GetByID(int id)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("SELECT * FROM StudentStatus WHERE StudentStatusID = @StudentStatusID", connection);
        command.Parameters.AddWithValue("@StudentStatusID", id);
        using var reader = command.ExecuteReader();
        if (reader.Read())
            return new StudentStatusModel(
                reader.GetInt32(0),
                reader.IsDBNull(1) ? null : reader.GetBoolean(1),
                reader.IsDBNull(2) ? null : reader.GetString(2),
                reader.GetInt32(3),
                reader.GetInt32(4));
        return null;
    }

    public List<StudentStatusModel> GetStudentStatusesBySectionID(int SectionID)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("SELECT * FROM StudentStatus WHERE SectionID = @SectionID", connection);
        command.Parameters.AddWithValue("@SectionID", SectionID);
        using var reader = command.ExecuteReader();
        var result = new List<StudentStatusModel>();
        while (reader.Read())
            result.Add(new StudentStatusModel(
                reader.GetInt32(0),
                reader.IsDBNull(1) ? null : reader.GetBoolean(1),
                reader.IsDBNull(2) ? null : reader.GetString(2),
                reader.GetInt32(3),
                reader.GetInt32(4)));
        return result;
    }

    public List<StudentStatusInfoPerTermCourse> StudentStatusesInfo_TermCourseAndStudent(int StudentID, int TermCourseID)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("Get_StudentStatus_For_Student_InSpecificTermCourse", connection)
        {
            CommandType = CommandType.StoredProcedure
        };
        command.Parameters.AddWithValue("@StudentID", StudentID);
        command.Parameters.AddWithValue("@TermCourseID", TermCourseID);
        using var reader = command.ExecuteReader();
        var result = new List<StudentStatusInfoPerTermCourse>();
        while (reader.Read())
            result.Add(new StudentStatusInfoPerTermCourse(
                reader.IsDBNull(0) ? null : reader.GetInt32(0),
                reader.IsDBNull(1) ? null : reader.GetDateTime(1),
                reader.IsDBNull(2) ? null : reader.GetBoolean(2),
                reader.IsDBNull(3) ? null : reader.GetString(3)));
        return result;
    }
}
