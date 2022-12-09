using AttendanceSystem.Models.ModelValidator;
using AttendanceSystem.Presenter.IPresenter;
using Models.Enums;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Presenter.Presenter.ClassManegementPresenter
{
    public partial class ClassManegementPresenter
    {
        private void RaiseStudentSectionEvents()
        {
            view.LoadStudents += View_LoadStudents;
            view.Search += View_Search;
            view.AddSection += View_AddSection;
        }

        private void View_AddSection(object? sender, EventArgs e)
        {
            try
            {
                ModelValidation.IsValid<SectionModel>(view.SectionModel);
                unitOFWork.SectionRepository.Add(view.SectionModel);
                unitOFWork.Save();
                view.IsSucess = true;
                view.Message = "Added Successfully";
            }
            catch (Exception ex)
            {
                view.IsSucess = false;
                if (ex.InnerException is not null)
                    view.Message = ex.InnerException.Message;
                else
                    view.Message = ex.Message;

            }
            finally
            {
                unitOFWork.ClearTracker();
            }
        }

        private void View_Search(object? sender, EventArgs e)
        {
            var searchModel = view.SearchStudentModel;
            var students = unitOFWork.StudentRepository.GetAll();
            students = students.Where(u => u.StudnetId.Contains(searchModel.SearchString) || u.FullName.Contains(searchModel.SearchString)).ToList();
            if (searchModel.Grade != Grade.none)
                students = students.Where(u => u.Grade == searchModel.Grade).ToList();
            if (searchModel.Major != Major.none)
                students = students.Where(u => u.Major == searchModel.Major).ToList();
            if (searchModel.EntryYear != 0)
                students = students.Where(u => u.EntryYear == searchModel.EntryYear).ToList();
            view.Students = students;
        }

        private void View_LoadStudents(object? sender, EventArgs e)
        {
            view.Students = unitOFWork.StudentRepository.GetAll();
        }
    }
}
