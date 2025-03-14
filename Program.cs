using Veterinary.Models;
using Veterinary.Views;
using Veterinary.Presenters;
using Veterinary._Repositories;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;

namespace Veterinary
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

            var sqlConnectionString = Properties.Settings.Default.sqlConnection;
            IMainView view = new MainView();
            new MainPresenter(view, sqlConnectionString);

            Application.Run((Form)view);
        }
    }
}