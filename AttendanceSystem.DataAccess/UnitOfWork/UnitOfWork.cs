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
    private readonly IMajorRepository _MajorsRepository;
    private readonly ITermRepository _TermRepository;
    private readonly ITermCourseRepository _TermCourseRepository;

    public UnitOfWork()
    {

        _CourseRepository = new CourseRepository_AdoSqlServer();
        _SectionRepository = new SectionRepository_AdoSqlServer();
        _StudentRepository = new StudentRepository_AdoSqlServer();
        _StudentStatusRepository = new StudentStatusRepository_AdoSqlServer();
        _TeacherRepository = new TeacherRepository_AdoSqlServer();
        _UserRepository = new UserRepository_AdoSqlServer();
        _DegreeRepository = new DegreeRepository_AdoSqlServer();
        _MajorsRepository = new MajorRepository_AdoSqlServer();
        _TermRepository = new TermRepository_AdoSqlServer();
        _TermCourseRepository = new TermCourseRepository_AdoSqlServer();

    }

    public ICourseRepository CourseRepository => _CourseRepository;
    public ISectionRepository SectionRepository => _SectionRepository;
    public IStudentRepository StudentRepository => _StudentRepository;
    public IStudentStatusRepository StudentStatusRepository => _StudentStatusRepository;
    public ITeacherRepository TeacherRepository => _TeacherRepository;
    public IUserRepository UserRepository => _UserRepository;  
    public IDegreeRepository DegreeRepository => _DegreeRepository;
    public IMajorRepository MajorRepository => _MajorsRepository;
    public ITermRepository TermRepository => _TermRepository;
    public ITermCourseRepository TermCourseRepository => _TermCourseRepository;

    public IProtestRepository ProtestRepository => throw new NotImplementedException();


}
