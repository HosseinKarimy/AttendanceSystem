using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories;
using AttendanceSystem.DataAccess.Repositories.IRepositories;

namespace AttendanceSystem.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOFWork
    {
        private readonly ICourseRepository _CourseRepository;
        private readonly ISectionRepository _SectionRepository;
        private readonly IStudentRepository _StudentRepository;
        private readonly IStudentStatusRepository _StudentStatusRepository;
        private readonly ITeacherRepository _TeacherRepository;

        AppDbContext _appDbContext = new();

        public UnitOfWork()
        {
            _CourseRepository = new CourseRepository(_appDbContext);
            _SectionRepository = new SectionRepository(_appDbContext);
            _StudentRepository = new StudentRepository(_appDbContext);
            _StudentStatusRepository = new StudentStatusRepository(_appDbContext);
            _TeacherRepository = new TeacherRepository(_appDbContext);
        }

        public ICourseRepository CourseRepository => _CourseRepository;
        public ISectionRepository SectionRepository => _SectionRepository;
        public IStudentRepository StudentRepository => _StudentRepository;
        public IStudentStatusRepository StudentStatusRepository => _StudentStatusRepository;
        public ITeacherRepository TeacherRepository => _TeacherRepository;

        public void ClearTracker()
        {
            _appDbContext.ChangeTracker.Clear();
        }

        public void Save()
        {
            _appDbContext.SaveChanges();
        }
    }
}
