using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using AttendanceSystem.Models.Ado_SqlServer;
using System.Data.SqlClient;

namespace AttendanceSystem.DataAccess.Repositories.AdoSqlServer;

public class StudentRepository_AdoSqlServer : IStudentRepository
{
    public int Add(StudentModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("INSERT INTO Student (FirstName, LastName, FatherName, BirthDate, MajorID, DegreeID, StudentID) VALUES (@FirstName, @LastName, @FatherName, @BirthDate, @MajorID, @DegreeID, @StudentID); SELECT SCOPE_IDENTITY();", connection);
        command.Parameters.AddWithValue("@FirstName", entity.FirstName);
        command.Parameters.AddWithValue("@LastName", entity.LastName);
        command.Parameters.AddWithValue("@FatherName", (object?)entity.FatherName ?? DBNull.Value);
        command.Parameters.AddWithValue("@BirthDate", (object?)entity.BirthDate ?? DBNull.Value);
        command.Parameters.AddWithValue("@MajorID", entity.MajorID);
        command.Parameters.AddWithValue("@DegreeID", entity.DegreeID);
        command.Parameters.AddWithValue("@StudentID", entity.StudentID);
        return Convert.ToInt32(command.ExecuteScalar());
    }

    public void Update(StudentModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("UPDATE Student SET FirstName = @FirstName, LastName = @LastName, FatherName = @FatherName, BirthDate = @BirthDate WHERE StudentID = @StudentID", connection);
        command.Parameters.AddWithValue("@FirstName", entity.FirstName);
        command.Parameters.AddWithValue("@LastName", entity.LastName);
        command.Parameters.AddWithValue("@FatherName", (object?)entity.FatherName ?? DBNull.Value);
        command.Parameters.AddWithValue("@BirthDate", (object?)entity.BirthDate ?? DBNull.Value);
        command.Parameters.AddWithValue("@StudentID", entity.StudentID);
        command.ExecuteNonQuery();
    }

    public void Delete(StudentModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("DELETE FROM Student WHERE StudentID = @StudentID", connection);
        command.Parameters.AddWithValue("@StudentID", entity.StudentID);
        command.ExecuteNonQuery();
    }

    public List<StudentModel> GetAll()
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("SELECT * FROM Student", connection);
        using var reader = command.ExecuteReader();
        var result = new List<StudentModel>();
        while (reader.Read())
            result.Add(new StudentModel(
                reader.GetString(0),
                reader.GetString(1),
                reader.IsDBNull(2) ? null : reader.GetString(2),
                reader.IsDBNull(3) ? null : reader.GetDateTime(3),
                reader.GetInt32(4),
                reader.GetInt32(5),
                reader.GetInt32(6)));
        return result;
    }

    public int GetByID(int id)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("SELECT * FROM Student WHERE StudentID = @StudentID", connection);
        command.Parameters.AddWithValue("@StudentID", id);
        using var reader = command.ExecuteReader();
        if (reader.Read())
            return reader.GetInt32(6);
        return -1;
    }
}
