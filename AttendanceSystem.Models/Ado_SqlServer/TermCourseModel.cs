namespace AttendanceSystem.Models.Ado_SqlServer;

public record TermCourseModel(int TermCourseID, DateTime? MidTermExamDate, DateTime? FinalExamDate, int CourseID, int TermID, int UserID);
