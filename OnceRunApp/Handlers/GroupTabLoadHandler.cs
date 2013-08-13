using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OnceRunApp.Base;
using OnceRunApp.Models;
using OnceRunApp.Controls;

namespace OnceRunApp.Handlers
{
    public class GroupTabLoadHandler : IHandler
    {
        public GroupTabLoadHandler(AppTabPage tabPage)
        {
            this.TabPage = tabPage;
        }

        public AppTabPage TabPage { get; set; }

        public void Execute()
        {
            this.TabPage.Invoke(new Action(() =>
            {
                this.TabPage.DataBindings.Add(new Binding("Tag", this.TabPage.Group, "Id"));
                this.TabPage.DataBindings.Add(new Binding("Text", this.TabPage.Group, "Name"));
                this.TabPage.DataBindings.Add(new Binding("ToolTipText", this.TabPage.Group, "Description"));

                int index = 0;
                foreach (AppItem item in this.TabPage.Group.AppItems)
                {
                    this.TabPage.NewAppControlOnPage(index, item);
                    ++index;
                }
                this.TabPage.ResumeLayout(true);

            }));
        }
    }
}
