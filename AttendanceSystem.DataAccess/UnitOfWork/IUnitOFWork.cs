using AttendanceSystem.DataAccess.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.DataAccess.UnitOfWork
{
    public interface IUnitOFWork
    {
        public ICourseRepository CourseRepository { get; }
        public ISectionRepository SectionRepository { get; }
        public IStudentRepository StudentRepository { get; }
        public IStudentStatusRepository StudentStatusRepository { get; }
        public ITeacherRepository TeacherRepository { get; }
        public IUserRepository UserRepository { get; }

        public void Save();
        public void ClearTracker();
    }
}
