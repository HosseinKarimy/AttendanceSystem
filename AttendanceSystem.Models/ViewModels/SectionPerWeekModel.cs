namespace AttendanceSystem.Models.ViewModels;

public record SectionPerWeekModel(TimeOnly StartTime, TimeSpan Duration, DayOfWeek Day);
