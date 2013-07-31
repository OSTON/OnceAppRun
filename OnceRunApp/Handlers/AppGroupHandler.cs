using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OnceRunApp.Base;
using OnceRunApp.Models;
using OnceRunApp.Services;
using OnceRunApp.Controls;
using OnceRunApp.UIHelpers;

namespace OnceRunApp.Handlers
{
    public class AppGroupHandler : IHandler
    {

        public AppGroupHandler(RunForm form,GroupAction action)
        {
            this.Form = form;
            this.Action = action; 
        }

        public RunForm Form { get; private set; }
        public GroupAction Action { get;private set; }   

        public void Execute()
        {
            this.Form.BeginInvoke(new Action(() =>
            {
                GroupForm form = new GroupForm(this.Action);

                switch (this.Action)
                {
                    case GroupAction.New: //New App Group
                        
                        if (form.ShowDialog(this.Form) == System.Windows.Forms.DialogResult.OK)
                        {
                            AppService.AddAppGroup(form.Group);
                            this.Form.AppGroupTab.Controls.Add(new AppGroupTabPage(form.Group));
                            this.Form.AppGroupTab.ResumeLayout(true);
                        }
                        break;
                    case GroupAction.Edit: //Edit App Group

                        if (this.Form.CurrentPage != null)
                        {
                            form.Group = this.Form.CurrentPage.Group;
                            if (form.ShowDialog(this.Form) == System.Windows.Forms.DialogResult.OK)
                            {
                                AppService.UpdateAppGroup(form.Group);
                                this.Form.CurrentPage.Group = form.Group;
                            }
                        }
                        break;
                    case GroupAction.Delete: //Delete App Group

                        if (this.Form.CurrentPage != null)
                        {
                            if (UiMessager.ShowConfirm("Are you sure to remove current group?") == System.Windows.Forms.DialogResult.Yes)
                            {
                                AppService.RemoveAppGroup(this.Form.CurrentPage.Group);
                                this.Form.AppGroupTab.Controls.Remove(this.Form.CurrentPage);
                                this.Form.AppGroupTab.ResumeLayout(true);
                            }
                        }
                        break;
                    case GroupAction.Shortcut: //Create App Group Shortcut

                        if (this.Form.CurrentPage != null)
                        {
                            AppService.CreateShortcut(this.Form.CurrentPage.Group);
                            UiMessager.ShowInfo("Group shortcut is created sucessfully!");
                        }
                        break;

                    case GroupAction.Run: //Run App Group Items
                        
                        if (this.Form.CurrentPage != null)
                        {
                            AppService.RunApps(this.Form.CurrentPage.Group);
                        }
                        break;
                }
            }));
        }

    }
}
