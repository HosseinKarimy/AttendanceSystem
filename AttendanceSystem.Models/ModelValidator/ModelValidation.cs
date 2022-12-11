using Models.Models;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Models.Enums;

namespace AttendanceSystem.Models.ModelValidator;

public class ModelValidation
{
    private static StringBuilder sb = new();
    private static bool result;
    public static bool IsValid<TEntity>(TEntity entity)
    {
        sb.Clear();
        List<ValidationResult> results = new();
        ValidationContext context = new(entity);
        result = Validator.TryValidateObject(entity, context, results, true);
        CustomValidation(entity);
        if (result is true)
            return true;
        foreach (var item in results)
            sb.AppendLine(item.ErrorMessage);
        throw new ArgumentException(sb.ToString());

    }

    private static void CustomValidation<TEntity>(TEntity entity)
    {
        if (entity is StudentModel)
        {
            if ((entity as StudentModel)!.Major == Major.none)
            {
                result = false;
                sb.AppendLine("The Major field required");
            }
            if ((entity as StudentModel)!.Grade == Grade.none)
            {
                result = false;
                sb.AppendLine("The Grade field required");
            }
        }
        if (entity is CourseModel)
        {
            if ((entity as CourseModel)!.Students.Count < 3)
            {
                result = false;
                sb.AppendLine("Add at least 3 students");
            }
            if ((entity as CourseModel)!.Sections.Count < 1)
            {
                result = false;
                sb.AppendLine("Add at least 1 section");
            }
        }
    }
}
