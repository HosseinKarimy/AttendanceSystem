using AttendanceSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Presenter.AdoPresenter.OtherManagementPresenter
{
    public partial class OtherManagementPresenter
    {
        private void RaiseMajorEvents()
        {
            otherManagementView.LoadMajors += LoadMajors;
            otherManagementView.SaveCreateMajor += SaveCreateMajor;
            otherManagementView.DeleteMajor += DeleteMajor;
        }

        private void DeleteMajor(object? sender, EventArgs e)
        {
            try
            {
                unitOFWork.MajorRepository.Delete(otherManagementView.MajorModel);
                otherManagementView.Message = "Major Deleted From DataBase...";
                otherManagementView.IsSucess = true;
            }
            catch (Exception ex)
            {
                otherManagementView.Message = ex.Message;
                otherManagementView.IsSucess = false;
            }
        }

        private void LoadMajors(object? sender, EventArgs e)
        {
            try
            {
                otherManagementView.Majors = unitOFWork.MajorRepository.GetAll();
                otherManagementView.IsSucess = true;
            }
            catch (Exception ex)
            {
                otherManagementView.Message = ex.Message;
                otherManagementView.IsSucess = false;
            }
        }

        private void SaveCreateMajor(object? sender, EventArgs e)
        {
            switch (otherManagementView.ActionType)
            {
                case ActionType.Create:
                    try
                    {
                        unitOFWork.MajorRepository.Add(otherManagementView.MajorModel);
                        otherManagementView.Message = "Major Added To DataBase...";
                        otherManagementView.IsSucess = true;
                    }
                    catch (Exception ex)
                    {
                        otherManagementView.Message = ex.Message;
                        otherManagementView.IsSucess = false;
                    }
                    break;
                case ActionType.Update:
                    try
                    {
                        unitOFWork.MajorRepository.Update(otherManagementView.MajorModel);
                        otherManagementView.Message = "Major Updated From DataBase...";
                        otherManagementView.IsSucess = true;
                    }
                    catch (Exception ex)
                    {
                        otherManagementView.Message = ex.Message;
                        otherManagementView.IsSucess = false;
                    }
                    break;
            }
        }

    }
}
