using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using OnceRunApp.Models;
using OnceRunApp.Services;
using OnceRunApp.UIHelpers;
using OnceRunApp.Utilities;

namespace OnceRunApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new RunForm());
            }
            else
            {
                string executeGroupId = args[0];
                AppService.OnAppRunError += AppService_OnAppRunError;
                AppService.RunApps(executeGroupId);
            }

            AppLogger.Logger.Trace("App starting...");
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            UiMessager.Error("UnhandledException-" + (e.ExceptionObject as Exception).Message);
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            UiMessager.Error("ThreadException-"+e.Exception.Message);
            
        }

        static void AppService_OnAppRunError(AppItemEventArgs e)
        {
            UiMessager.Error(string.Format("App [{0}] is run error,{1}", e.Item.Name, e.Error.Message));
        }
    }
}
