using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Models.Ado_SqlServer.Views;
using AttendanceSystem.Models.Search_Models;
using System.Data;
using System.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace AttendanceSystem.DataAccess.Repositories.AdoSqlServer;

public class StudentRepository_AdoSqlServer : IStudentRepository
{
    public int Add(StudentModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("INSERT INTO Student (FirstName, LastName, FatherName, BirthDate, MajorID, DegreeID, StudentID) VALUES (@FirstName, @LastName, @FatherName, @BirthDate, @MajorID, @DegreeID, @StudentID)", connection);
        command.Parameters.AddWithValue("@FirstName", entity.FirstName);
        command.Parameters.AddWithValue("@LastName", entity.LastName);
        command.Parameters.AddWithValue("@FatherName", (object?)entity.FatherName ?? DBNull.Value);
        command.Parameters.AddWithValue("@BirthDate", (object?)entity.BirthDate ?? DBNull.Value);
        command.Parameters.AddWithValue("@MajorID", entity.MajorID);
        command.Parameters.AddWithValue("@DegreeID", entity.DegreeID);
        command.Parameters.AddWithValue("@StudentID", entity.StudentID);
        command.ExecuteScalar();
        return entity.StudentID;
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

    public StudentModel? GetByID(int id)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("SELECT * FROM Student WHERE StudentID = @StudentID", connection);
        command.Parameters.AddWithValue("@StudentID", id);
        using var reader = command.ExecuteReader();
        if (reader.Read())
            return new StudentModel(
                reader.GetString(0),
                reader.GetString(1),
                reader.IsDBNull(2) ? null : reader.GetString(2),
                reader.IsDBNull(3) ? null : reader.GetDateTime(3),
                reader.GetInt32(4),
                reader.GetInt32(5),
                reader.GetInt32(6));
        return null;
    }

    public List<StudentInfoModel> GetAllWithInfo()
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("SELECT * FROM Students_Info", connection);
        using var reader = command.ExecuteReader();
        var result = new List<StudentInfoModel>();
        while (reader.Read())
            result.Add(new StudentInfoModel(
                reader.GetInt32(0),
                reader.GetString(1),
                reader.IsDBNull(2) ? null : reader.GetString(2),
                reader.GetString(3),
                reader.GetString(4)));
        return result;
    }

    public List<StudentInfoModel> SearchInStudentInfo(SearchStudentModel searchModel)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("Search_Students_Info", connection)
        {
            CommandType = CommandType.StoredProcedure
        };
        command.Parameters.AddWithValue("@StudentID", (object?)searchModel.StudentID ?? DBNull.Value);
        command.Parameters.AddWithValue("@FullName", (object?)searchModel.FullName ?? DBNull.Value);
        command.Parameters.AddWithValue("@DegreeName", (object?)searchModel.DegreeName ?? DBNull.Value);
        command.Parameters.AddWithValue("@MajorName", (object?)searchModel.MajorName ?? DBNull.Value);
        using var reader = command.ExecuteReader();
        var result = new List<StudentInfoModel>();
        while (reader.Read())
            result.Add(new StudentInfoModel(
                reader.GetInt32(0),
                reader.GetString(1),
                reader.IsDBNull(2) ? null : reader.GetString(2),
                reader.GetString(3),
                reader.GetString(4)));
        return result;
    }

    public StudentFullInfoModel GetStudentFullInfo(int StudentID)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("Get_Student_Full_Info", connection)
        {
            CommandType = CommandType.StoredProcedure
        };
        command.Parameters.AddWithValue("@StudentID", StudentID);
        using var reader = command.ExecuteReader();
        if (reader.Read())
            return new StudentFullInfoModel(
                reader.GetString(0),
                reader.GetString(1),
                reader.IsDBNull(2) ? null : reader.GetString(2),
                reader.IsDBNull(3) ? null : reader.GetDateTime(3),
                reader.GetString(4),
                reader.GetString(5),
                reader.GetInt32(6));
        throw new Exception(message: "User Not Found");
    }

    public StudentFullInfoModel GetAllStudentFullInfoOfSection(int SectionID)
    {
        throw new NotImplementedException();
    }
}
