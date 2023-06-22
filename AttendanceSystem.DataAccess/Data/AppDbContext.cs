using AttendanceSystem.Models.EfCore_Sqllite.Enums;
using AttendanceSystem.Models.EfCore_Sqllite.Models;
using Microsoft.EntityFrameworkCore;

namespace AttendanceSystem.DataAccess.Data;

public class AppDbContext : DbContext
{
    public string DbPath { get; }

    public AppDbContext()
    {
        //var folder = Environment.SpecialFolder.LocalApplicationData;
        //var path = Environment.GetFolderPath(folder);
        //DbPath = System.IO.Path.Join(path, "AttendanceSystem.db");
        DbPath = System.IO.Path.Join(AppContext.BaseDirectory, "AttendanceSystem.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source= {DbPath}");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdminModel>().HasData(
            new AdminModel() { Id = 1, FirstName = "Amin", LastName = "Enayat", UserName = "Admin" }
            );
        modelBuilder.Entity<StudentModel>().HasData(
              new StudentModel() { Id = 1, FirstName = "hossein", LastName = "Km", StudentId = "1111111111", Major = Major.Computer, Grade = Grade.Bachelor, EntryYear = 1398, FatherName = "Ali" },
            new StudentModel() { Id = 2, FirstName = "hamed", LastName = "gk", StudentId = "2222222222", Major = Major.Computer, Grade = Grade.Bachelor, EntryYear = 1398, FatherName = "habib" },
            new StudentModel() { Id = 3, FirstName = "reza", LastName = "mohammadi", StudentId = "123213133", Major = Major.Mechanics, Grade = Grade.Bachelor, EntryYear = 1397, FatherName = "mohammad" },
            new StudentModel() { Id = 4, FirstName = "ali", LastName = "aghaii", StudentId = "432432123", Major = Major.Computer, Grade = Grade.Bachelor, EntryYear = 1398, FatherName = "taghi" },
            new StudentModel() { Id = 5, FirstName = "hossein", LastName = "golab zadeh", StudentId = "605003040", Major = Major.Computer, Grade = Grade.Bachelor, EntryYear = 1399, FatherName = "jafar" },
            new StudentModel() { Id = 6, FirstName = "ali", LastName = "kazemeini", StudentId = "233423422", Major = Major.Computer, Grade = Grade.Bachelor, EntryYear = 1399, FatherName = "taghi" },
            new StudentModel() { Id = 7, FirstName = "behzad", LastName = "keramat", StudentId = "98989898", Major = Major.Electronics, Grade = Grade.Bachelor, EntryYear = 1398, FatherName = "abbas" },
            new StudentModel() { Id = 8, FirstName = "sajjad", LastName = "ghasemi", StudentId = "889889889", Major = Major.Industrial, Grade = Grade.Bachelor, EntryYear = 1398, FatherName = "abdullah" },
            new StudentModel() { Id = 9, FirstName = "reza", LastName = "sufi", StudentId = "696969696", Major = Major.none, Grade = Grade.Bachelor, EntryYear = 1400, FatherName = "changiz" },
            new StudentModel() { Id = 10, FirstName = "rajab", LastName = "chagho saz", StudentId = "8878988798", Major = Major.Mechanics, Grade = Grade.PhD, EntryYear = 1396, FatherName = "asghar" },
            new StudentModel() { Id = 11, FirstName = "azim", LastName = "morid", StudentId = "452432123", Major = Major.Civil, Grade = Grade.Bachelor, EntryYear = 1398, FatherName = "taghi" },
            new StudentModel() { Id = 12, FirstName = "yaghub", LastName = "leis", StudentId = "432462123", Major = Major.Architecture, Grade = Grade.AssociateDegree, EntryYear = 1398, FatherName = "taghi" },
            new StudentModel() { Id = 13, FirstName = "malek", LastName = "ashtar", StudentId = "532432123", Major = Major.Computer, Grade = Grade.Bachelor, EntryYear = 1392, FatherName = "mohammad" },
            new StudentModel() { Id = 14, FirstName = "sadegh", LastName = "mohammadi", StudentId = "932432123", Major = Major.Civil, Grade = Grade.Bachelor, EntryYear = 1398, FatherName = "taghi" },
            new StudentModel() { Id = 15, FirstName = "alireza", LastName = "mohammadi", StudentId = "432445212", Major = Major.Computer, Grade = Grade.Bachelor, EntryYear = 1398, FatherName = "taghi" },
            new StudentModel() { Id = 16, FirstName = "Milad", LastName = "majlesi", StudentId = "732432121", Major = Major.Computer, Grade = Grade.Bachelor, EntryYear = 1396, FatherName = "taghi" },
            new StudentModel() { Id = 17, FirstName = "mohammad", LastName = "shorang", StudentId = "4324422123", Major = Major.Computer, Grade = Grade.Bachelor, EntryYear = 1400, FatherName = "taghi" },
            new StudentModel() { Id = 18, FirstName = "abolfazl", LastName = "moaveni", StudentId = "411132123", Major = Major.Mathematics, Grade = Grade.Bachelor, EntryYear = 1398, FatherName = "taghi" },
            new StudentModel() { Id = 19, FirstName = "benyamin", LastName = "netaniaho", StudentId = "6666666666", Major = Major.none, Grade = Grade.Master, EntryYear = 1398, FatherName = "solomon" }

            );
        modelBuilder.Entity<TeacherModel>().HasData(
            new TeacherModel() { Id = 1, FirstName = "Amin", LastName = "Enayat", TeacherId = "18238213" },
            new TeacherModel() { Id = 2, FirstName = "Mehdi", LastName = "Enayat", TeacherId = "43243243" },
            new TeacherModel() { Id = 3, FirstName = "somaye", LastName = "amraee", TeacherId = "243425345" },
            new TeacherModel() { Id = 4, FirstName = "mousa", LastName = "mousa zade", TeacherId = "344351234" }
            );
        modelBuilder.Entity<UserModel>().HasData(
            new UserModel() { Id = 1, Password = "Admin", Role = Role.Admin, Username = "Admin", AdminId = 1, StudentId = null, TeacherId = null },
            new UserModel() { Id = 2, Password = "1234", Role = Role.Student, Username = "Student", StudentId = 1 , TeacherId = null , AdminId = null },
            new UserModel() { Id = 3, Password = "1234", Role = Role.Teacher, Username = "Teacher", TeacherId = 3 ,AdminId = null, StudentId = null}
        );
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<AdminModel> Admins { get; set; }
    public DbSet<CourseModel> Courses { get; set; }
    public DbSet<SectionModel> Sections { get; set; }
    public DbSet<StudentModel> Students { get; set; }
    public DbSet<StudentStatusModel> StudentsStatus { get; set; }
    public DbSet<TeacherModel> Teachers { get; set; }
    public DbSet<UserModel> Users { get; set; }
}

