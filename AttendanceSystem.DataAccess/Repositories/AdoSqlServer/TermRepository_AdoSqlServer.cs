using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using AttendanceSystem.Models.Ado_SqlServer;
using System.Data.SqlClient;

namespace AttendanceSystem.DataAccess.Repositories.AdoSqlServer;

public class TermRepository_AdoSqlServer :ITermRepository
{
    public int Add(TermModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("INSERT INTO Term (TermID, StartDate) VALUES (@TermID, @StartDate)", connection);
        command.Parameters.AddWithValue("@TermID", entity.TermID);
        command.Parameters.AddWithValue("@StartDate", entity.StartDate);
        command.ExecuteScalar();
        return entity.TermID;
    }

    public void Update(TermModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("UPDATE Term SET StartDate = @StartDate WHERE TermID = @TermID", connection);
        command.Parameters.AddWithValue("@StartDate", entity.StartDate);
        command.Parameters.AddWithValue("@TermID", entity.TermID);
        command.ExecuteNonQuery();
    }

    public void Delete(TermModel entity)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("DELETE FROM Term WHERE TermID = @TermID", connection);
        command.Parameters.AddWithValue("@TermID", entity.TermID);
        command.ExecuteNonQuery();
    }

    public List<TermModel> GetAll()
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("SELECT * FROM Term", connection);
        using var reader = command.ExecuteReader();
        var result = new List<TermModel>();
        while (reader.Read())
            result.Add(new TermModel(
                reader.GetInt32(0),
                reader.GetDateTime(1)));
        return result;
    }

    public TermModel? GetByID(int id)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand("SELECT * FROM Term WHERE TermID = @TermID", connection);
        command.Parameters.AddWithValue("@TermID", id);
        using var reader = command.ExecuteReader();
        if (reader.Read())
            return new TermModel(
                reader.GetInt32(0),
                reader.GetDateTime(1));
        return null;
    }
}
