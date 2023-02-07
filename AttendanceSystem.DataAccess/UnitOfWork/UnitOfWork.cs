using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories;
using AttendanceSystem.DataAccess.Repositories.AdoSqlServer;
using AttendanceSystem.DataAccess.Repositories.EfCoreSqlite;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using System;
using System.Data;

namespace AttendanceSystem.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOFWork
    {
        private readonly ICourseRepository _CourseRepository;
        private readonly ISectionRepository _SectionRepository;
        private readonly IStudentRepository _StudentRepository;
        private readonly IStudentStatusRepository _StudentStatusRepository;
        private readonly ITeacherRepository _TeacherRepository;
        private readonly IUserRepository _UserRepository;

        AppDbContext _appDbContext = new();

        public UnitOfWork()
        {
            var dbType = DataBaseType.EfCore_Sqlite;
            switch (dbType)
            {
                case DataBaseType.EfCore_Sqlite:
                    _CourseRepository = new CourseRepository_EfCoreSqlite(_appDbContext);
                    _SectionRepository = new SectionRepository_EfCoreSqlite(_appDbContext);
                    _StudentRepository = new StudentRepository_EfCoreSqlite(_appDbContext);
                    _StudentStatusRepository = new StudentStatusRepository_EfCoreSqlite(_appDbContext);
                    _TeacherRepository = new TeacherRepository_EfCoreSqlite(_appDbContext);
                    _UserRepository = new UserRepository_EfCoreSqlite(_appDbContext);
                    break;
                case DataBaseType.Ado_SqlServer:
                    _CourseRepository = new CourseRepository_AdoSqlServer();
                    _SectionRepository = new SectionRepository_AdoSqlServer();
                    _StudentRepository = new StudentRepository_AdoSqlServer();
                    _StudentStatusRepository = new StudentStatusRepository_AdoSqlServer();
                    _TeacherRepository = new TeacherRepository_AdoSqlServer();
                    _UserRepository = new UserRepository_AdoSqlServer();
                    break;
            }
        }

        public ICourseRepository CourseRepository => _CourseRepository;
        public ISectionRepository SectionRepository => _SectionRepository;
        public IStudentRepository StudentRepository => _StudentRepository;
        public IStudentStatusRepository StudentStatusRepository => _StudentStatusRepository;
        public ITeacherRepository TeacherRepository => _TeacherRepository;
        public IUserRepository UserRepository => _UserRepository;

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
