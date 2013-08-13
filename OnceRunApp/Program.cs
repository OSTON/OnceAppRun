using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using OnceRunApp.Base;
using OnceRunApp.Models;
using OnceRunApp.Services;

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

            //Register application exeption handlers.
            //The thread exception handler is use to handle the UI exceptions,
            //and the unhandled exception handler is use to handle Non-UI exceptions.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (object sender, System.Threading.ThreadExceptionEventArgs e) =>
            {
                if (e.Exception is MyAlertException)
                {
                    MyAlertException alert = (MyAlertException)e.Exception;
                    MyLogger.Instance.Warn("{0}{1}{2}", alert.Message, Environment.NewLine, alert.ToString());
                    UIMessager.ShowWarning(alert.Message);
                }
                else
                {
                    MyLogger.Instance.Error("{0}{1}{2}",e.Exception.Message,Environment.NewLine,e.Exception.ToString());
                    UIMessager.ShowError(e.Exception.Message);
                }

            };
            AppDomain.CurrentDomain.UnhandledException += (object sender, UnhandledExceptionEventArgs e) =>
            {
                Exception ex = e.ExceptionObject as Exception;
                MyLogger.Instance.Error("{0}{1}{2}",ex.Message,Environment.NewLine,ex.ToString());
                UIMessager.ShowError(ex.Message);
            };

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
                AppService.OnAppRunError += (AppItemEventArgs e) =>
                {
                    MyLogger.Instance.Error("{0}{1}{2}",e.Error.Message,Environment.NewLine,e.Error.ToString());
                    UIMessager.ShowError(string.Format("{0} is running error:{1}", e.Item.Name, e.Error.Message));
                };
                AppService.RunApps(executeGroupId);
            }

        }

    }
}
