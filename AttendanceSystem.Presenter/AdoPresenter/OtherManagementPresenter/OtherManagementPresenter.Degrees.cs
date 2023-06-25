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

        private void RaiseDegreeEvents()
        {
            otherManagementView.LoadDegrees += LoadDegrees;
            otherManagementView.SaveCreateDegree += SaveCreateDegree;
            otherManagementView.DeleteDegree += DeleteDegree;
        }

        private void DeleteDegree(object? sender, EventArgs e)
        {
            try
            {
                unitOFWork.DegreeRepository.Delete(otherManagementView.DegreeModel);
                otherManagementView.Message = "Degree Deleted From DataBase...";
                otherManagementView.IsSucess = true;
            }
            catch (Exception ex)
            {
                otherManagementView.Message = ex.Message;
                otherManagementView.IsSucess = false;
            }
        }

        private void SaveCreateDegree(object? sender, EventArgs e)
        {
            switch (otherManagementView.ActionType)
            {
                case ActionType.Create:
                    try
                    {
                        unitOFWork.DegreeRepository.Add(otherManagementView.DegreeModel);
                        otherManagementView.Message = "Degree Added To DataBase...";
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
                        unitOFWork.DegreeRepository.Update(otherManagementView.DegreeModel);
                        otherManagementView.Message = "Degree Updated From DataBase...";
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

        private void LoadDegrees(object? sender, EventArgs e)
        {
            try
            {
                otherManagementView.Degrees = unitOFWork.DegreeRepository.GetAll();
            }
            catch (Exception ex)
            {
                otherManagementView.Message = ex.Message;
                otherManagementView.IsSucess = false;
            }
        }
    }
}
