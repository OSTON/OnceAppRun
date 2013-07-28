using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using OnceRunApp.Base;
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
            LogService.Logger.Info("Application is running...");

            //Register application exeption handlers.
            //The thread exception handler is use to handle the UI exceptions,
            //and the unhandled exception handler is use to handle Non-UI exceptions.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            //By default,
            //If there is no args,we will run the setting form to setting the apps,
            //else will run the setting apps by group id that has setting as first arg.
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

        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;
            LogService.Logger.ErrorException("Unhandled Exception",ex);
            UiMessager.ShowError("Unhandled Exception-" + ex.Message);
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            if (e.Exception is InnerAlertException)
            {
                InnerAlertException ex = e.Exception as InnerAlertException;

                LogService.Logger.Info(ex.Message);
                switch (ex.Type)
                {
                    case AlertType.Error:
                        UiMessager.ShowError(ex.Message);
                        break;
                    case AlertType.Warning:
                        UiMessager.ShowWarning(ex.Message);
                        break;
                }
            }
            else
            {
                LogService.Logger.ErrorException("Thread Exception", e.Exception);
                UiMessager.ShowError("Thread Exception-" + e.Exception.Message);
            }
        }

        static void AppService_OnAppRunError(AppItemEventArgs e)
        {
            LogService.Logger.ErrorException("App Running Error", e.Error);
            UiMessager.ShowError(string.Format("App - {0} is running error,{1}", e.Item.Name, e.Error.Message));
        }
    }
}
