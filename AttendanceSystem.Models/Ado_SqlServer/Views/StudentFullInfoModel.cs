namespace AttendanceSystem.Models.Ado_SqlServer.Views;

public record StudentFullInfoModel(string FirstName, string LastName, string? FatherName, DateTime? BirthDate, string MajorName, string DegreeName, int StudentID) : IViewModel;
