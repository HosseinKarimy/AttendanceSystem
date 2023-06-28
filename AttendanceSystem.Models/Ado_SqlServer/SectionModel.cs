namespace AttendanceSystem.Models.Ado_SqlServer;

public record SectionModel(int SectionID, int? SectionNumber, TimeSpan? Duration, DateTime? Date, int TermCourseID);
