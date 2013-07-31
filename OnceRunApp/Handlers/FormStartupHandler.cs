using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OnceRunApp.Base;
using OnceRunApp.Models;
using OnceRunApp.Controls;
using OnceRunApp.Services;
using OnceRunApp.UIHelpers;

namespace OnceRunApp.Handlers
{
    public class FormStartupHandler : IHandler
    {
        public FormStartupHandler(RunForm form)
        {
            this.Form = form;
        }

        /// <summary>
        /// Main form instance
        /// </summary>
        public RunForm Form { get;private set; }

        /// <summary>
        /// When form is loaded:
        /// 1.Loading all app groups.
        /// 2.Register app running error event handler.
        /// </summary>
        public void Execute()
        {
            this.Form.BeginInvoke(new Action(() =>
            {
                foreach (AppGroup group in AppService.GetAppGroups())
                {
                    this.Form.AppGroupTab.Controls.Add(new AppGroupTabPage(group));
                }
                this.Form.AppGroupTab.ResumeLayout(true);

                AppService.OnAppRunError += (AppItemEventArgs e) =>
                {
                    UiMessager.ShowError(string.Format("App - {0} is run error,{1}!", e.Item.Name, e.Error.Message));
                };
            }));
        }
    }
}
