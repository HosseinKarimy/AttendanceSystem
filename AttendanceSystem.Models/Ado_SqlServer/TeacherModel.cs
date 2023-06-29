namespace AttendanceSystem.Models.Ado_SqlServer;

public record TeacherModel(string FirstName, string LastName, string? FatherName, DateTime? BirthDate, int TeacherID)
{
    public string FullName => $"{FirstName} {LastName}";
}
