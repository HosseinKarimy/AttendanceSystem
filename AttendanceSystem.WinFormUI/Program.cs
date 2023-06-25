using AttendanceSystem.DataAccess.UnitOfWork;
using AttendanceSystem.Presenter.AdoPresenter.OtherManagementPresenter;

namespace AttendanceSystem.WinFormUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var frm = new OtherManagementForm();
            _ = new OtherManagementPresenter(frm, new UnitOfWork());
            Application.Run(frm);
        }
    }
}