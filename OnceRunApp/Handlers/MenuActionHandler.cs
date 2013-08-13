using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OnceRunApp.Base;
using OnceRunApp.Models;
using OnceRunApp.Services;
using OnceRunApp.Controls;

namespace OnceRunApp.Handlers
{
    public class MenuActionHandler : IHandler
    {

        public MenuActionHandler(RunForm form,BaseAction action)
        {
            this.Form = form;
            this.Action = action; 
        }

        public RunForm Form { get; private set; }
        public BaseAction Action { get;private set; }   

        public void Execute()
        {
            this.Form.BeginInvoke(new Action(() =>
            {
                GroupForm form = new GroupForm(this.Action);

                switch (this.Action)
                {
                    case BaseAction.New: //New App Group
                        
                        if (form.ShowDialog(this.Form) == System.Windows.Forms.DialogResult.OK)
                        {
                            AppService.AddAppGroup(form.Group);
                            this.Form.AppGroupTab.Controls.Add(new AppTabPage(form.Group));
                            this.Form.AppGroupTab.ResumeLayout(true);
                        }
                        break;
                    case BaseAction.Edit: //Edit App Group

                        if (this.Form.CurrentPage != null)
                        {
                            form.Group = this.Form.CurrentPage.Group;
                            if (form.ShowDialog(this.Form) == DialogResult.OK)
                            {
                                AppService.UpdateAppGroup(form.Group);
                                this.Form.CurrentPage.Group = form.Group;
                            }
                        }
                        break;
                    case BaseAction.Delete: //Delete App Group

                        if (this.Form.CurrentPage != null)
                        {
                            if (UIMessager.ShowConfirm("Are you sure to remove current group?") == DialogResult.Yes)
                            {
                                AppService.RemoveAppGroup(this.Form.CurrentPage.Group);
                                this.Form.AppGroupTab.Controls.Remove(this.Form.CurrentPage);
                                this.Form.AppGroupTab.ResumeLayout(true);
                            }
                        }
                        break;
                    case BaseAction.Shortcut: //Create App Group Shortcut

                        if (this.Form.CurrentPage != null)
                        {
                            AppService.CreateShortcut(this.Form.CurrentPage.Group);
                            UIMessager.ShowInfo(string.Format("{0} shortcut is created sucessfully!",this.Form.CurrentPage.Group.Name));
                        }
                        break;

                    case BaseAction.Run: //Run App Group Items
                        
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
