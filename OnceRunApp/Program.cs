using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using OnceRunApp.Models;
using OnceRunApp.Services;
using OnceRunApp.UIHelpers;

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

        static void AppService_OnAppRunError(AppItemEventArgs e)
        {
            UiMessager.Error(string.Format("App [{0}] is run error,{1}", e.Item.Name, e.Error.Message));
        }
    }
}
