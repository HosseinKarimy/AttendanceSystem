using AttendanceSystem.DataAccess.Repositories.AdoSqlServer;
using AttendanceSystem.DataAccess.Repositories.IRepositories;

namespace AttendanceSystem.DataAccess.UnitOfWork;

public class UnitOfWork : IUnitOFWork
{
    private readonly ICourseRepository _CourseRepository;
    private readonly ISectionRepository _SectionRepository;
    private readonly IStudentRepository _StudentRepository;
    private readonly IStudentStatusRepository _StudentStatusRepository;
    private readonly ITeacherRepository _TeacherRepository;
    private readonly IUserRepository _UserRepository;
    private readonly IDegreeRepository _DegreeRepository;
    private readonly IMajorRepository _MejorRepository;

    public UnitOfWork()
    {

        _CourseRepository = new CourseRepository_AdoSqlServer();
        _SectionRepository = new SectionRepository_AdoSqlServer();
        _StudentRepository = new StudentRepository_AdoSqlServer();
        _StudentStatusRepository = new StudentStatusRepository_AdoSqlServer();
        _TeacherRepository = new TeacherRepository_AdoSqlServer();
        _UserRepository = new UserRepository_AdoSqlServer();
        _DegreeRepository = new DegreeRepository_AdoSqlServer();
        _MejorRepository = new MajorRepository_AdoSqlServer();
        

    }

    public ICourseRepository CourseRepository => _CourseRepository;
    public ISectionRepository SectionRepository => _SectionRepository;
    public IStudentRepository StudentRepository => _StudentRepository;
    public IStudentStatusRepository StudentStatusRepository => _StudentStatusRepository;
    public ITeacherRepository TeacherRepository => _TeacherRepository;
    public IUserRepository UserRepository => _UserRepository;  
    public IDegreeRepository DegreeRepository => _DegreeRepository;
    public IMajorRepository MajorRepository => _MejorRepository;

    public IProtestRepository ProtestRepository => throw new NotImplementedException();

    public ITermCourseRepository TermCourseRepository => throw new NotImplementedException();

    public ITermRepository TermRepository => throw new NotImplementedException();
}
