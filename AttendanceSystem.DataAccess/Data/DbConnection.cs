using System.Data.SqlClient;

namespace AttendanceSystem.DataAccess.Data;

public class DbConnection
{
    public static SqlConnection SqlConnection => new("Data Source=. ; Initial Catalog = AttendancesSystem; Integrated Security = True; ");
}
