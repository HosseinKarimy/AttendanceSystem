using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using AttendanceSystem.Models.Ado_SqlServer;
using System.Data.SqlClient;

namespace AttendanceSystem.DataAccess.Repositories.AdoSqlServer
{
    public class UserRepository_AdoSqlServer : IUserRepository
    {
        public int Add(UsersModel entity)
        {
            using var connection = DbConnection.SqlConnection;
            connection.Open();
            var command = new SqlCommand("INSERT INTO Users (UserID, Password, UserType) VALUES (@UserID, @Password, @UserType); SELECT SCOPE_IDENTITY();", connection);
            command.Parameters.AddWithValue("@UserID", entity.UserID);
            command.Parameters.AddWithValue("@Password", entity.Password);
            command.Parameters.AddWithValue("@UserType", entity.UserType);
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public void Update(UsersModel entity)
        {
            using var connection = DbConnection.SqlConnection;
            connection.Open();
            var command = new SqlCommand("UPDATE Users SET Password = @Password, UserType = @UserType WHERE UserID = @UserID", connection);
            command.Parameters.AddWithValue("@Password", entity.Password);
            command.Parameters.AddWithValue("@UserType", entity.UserType);
            command.Parameters.AddWithValue("@UserID", entity.UserID);
            command.ExecuteNonQuery();
        }

        public void Delete(UsersModel entity)
        {
            using var connection = DbConnection.SqlConnection;
            connection.Open();
            var command = new SqlCommand("DELETE FROM Users WHERE UserID = @UserID", connection);
            command.Parameters.AddWithValue("@UserID", entity.UserID);
            command.ExecuteNonQuery();
        }

        public List<UsersModel> GetAll()
        {
            using var connection = DbConnection.SqlConnection;
            connection.Open();
            var command = new SqlCommand("SELECT * FROM Users", connection);
            using var reader = command.ExecuteReader();
            var result = new List<UsersModel>();
            while (reader.Read())
                result.Add(new UsersModel(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetInt32(2)));
            return result;
        }

        public int GetByID(int id)
        {
            using var connection = DbConnection.SqlConnection;
            connection.Open();
            var command = new SqlCommand("SELECT * FROM Users WHERE UserID = @UserID", connection);
            command.Parameters.AddWithValue("@UserID", id);
            using var reader = command.ExecuteReader();
            if (reader.Read())
                return reader.GetInt32(0);
            return -1;
        }
    }
}
