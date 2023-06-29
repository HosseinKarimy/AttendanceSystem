namespace AttendanceSystem.Models.Ado_SqlServer;

public class StudentStatusModel
{
    public int StudentStatusID { get; init; }
    public bool? IsPresent { get; set; }
    public string? Description { get; set; }
    public int SectionID { get; init; }
    public int StudentID { get; init; }

    public StudentStatusModel(int studentStatusID, bool? isPresent, string? description, int sectionID, int studentID)
    {
        StudentStatusID = studentStatusID;
        IsPresent = isPresent;
        Description = description;
        SectionID = sectionID;
        StudentID = studentID;
    }
}