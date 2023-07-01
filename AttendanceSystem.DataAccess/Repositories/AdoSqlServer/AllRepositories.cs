using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using System.Data;
using System.Data.SqlClient;

namespace AttendanceSystem.DataAccess.Repositories.AdoSqlServer;

public class AllRepositories : IAllRepositories
{
    public DataTable GetSomeDataFromTable(string tableName, string orderBy,string searchBy,string searchString, int offset, int fetchCount)
    {
        using var connection = DbConnection.SqlConnection;
        connection.Open();
        var command = new SqlCommand($"SELECT * FROM {tableName} " +
        $"WHERE {searchBy} like @searchString " +
        $"ORDER BY {orderBy} " +
        $"OFFSET @offset ROWS " +
        $"FETCH NEXT @fetchCount ROWS ONLY", connection);
        command.Parameters.AddWithValue("@searchString", $"%{searchString}%");
        command.Parameters.AddWithValue("@offset", offset);
        command.Parameters.AddWithValue("@fetchCount", fetchCount);

        SqlDataAdapter adapter = new(command);
        DataTable dataTable = new();
        adapter.Fill(dataTable);

        return dataTable;
    }
}
