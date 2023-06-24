namespace AttendanceSystem.Models.Ado_SqlServer;

public record StudentStatusModel(int StudentStatusID, bool? IsPresent, string? Description, int SectionID, int StudentID);
