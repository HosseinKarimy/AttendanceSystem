namespace AttendanceSystem.Models.Ado_SqlServer;

public record StudentModel(string FirstName, string LastName, string? FatherName, DateTime? BirthDate, int MajorID, int DegreeID, int UserID);
