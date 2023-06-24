using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using AttendanceSystem.Models.Ado_SqlServer;
using System.Data.SqlClient;

namespace AttendanceSystem.DataAccess.Repositories.AdoSqlServer;

public class AdminRepository_AdoSqlServer : IAdminRepository
{
    public int Add(AdminModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("INSERT INTO Admin (FirstName, LastName, AdminID) VALUES (@FirstName, @LastName, @AdminID); SELECT SCOPE_IDENTITY();", connection);
        command.Parameters.AddWithValue("@FirstName", entity.FirstName);
        command.Parameters.AddWithValue("@LastName", entity.LastName);
        command.Parameters.AddWithValue("@AdminID", entity.AdminID);
        return Convert.ToInt32(command.ExecuteScalar());
    }

    public void Update(AdminModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("UPDATE Admin SET FirstName = @FirstName, LastName = @LastName WHERE AdminID = @AdminID", connection);
        command.Parameters.AddWithValue("@FirstName", entity.FirstName);
        command.Parameters.AddWithValue("@LastName", entity.LastName);
        command.Parameters.AddWithValue("@AdminID", entity.AdminID);
        command.ExecuteNonQuery();
    }

    public void Delete(AdminModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("DELETE FROM Admin WHERE AdminID = @AdminID", connection);
        command.Parameters.AddWithValue("@AdminID", entity.AdminID);
        command.ExecuteNonQuery();
    }

    public List<AdminModel> GetAll()
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("SELECT * FROM Admin", connection);
        using var reader = command.ExecuteReader();
        var result = new List<AdminModel>();
        while (reader.Read())
            result.Add(new AdminModel(reader.GetString(0), reader.GetString(1), reader.GetInt32(2)));
        return result;
    }

    public int GetByID(int id)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("SELECT * FROM Admin WHERE AdminID = @AdminID", connection);
        command.Parameters.AddWithValue("@AdminID", id);
        using var reader = command.ExecuteReader();
        if (reader.Read())
            return reader.GetInt32(2);
        return -1;
    }
}
