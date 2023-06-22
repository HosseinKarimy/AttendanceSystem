namespace AttendanceSystem.Models.Ado_SqlServer;

public record SectionModel(int SectionID, int? SectionNumber, int? Duration, TimeSpan? StartTime, DateTime? Day, DateTime? Date, int TermCourseID);
