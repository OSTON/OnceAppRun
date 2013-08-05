using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OnceRunApp.Base;
using OnceRunApp.Models;
using OnceRunApp.Controls;

namespace OnceRunApp.Handlers
{
    public class AppAddedHandler : IHandler
    {
        public AppAddedHandler(AppTabPage tabPage, AppControl source, AppItem item)
        {
            this.TabPage = tabPage;
            this.Source = source;
            this.Item = item;
        }

        public AppTabPage TabPage { get; set; }
        public AppControl Source { get; set; }
        public AppItem Item { get; set; }

        public void Execute()
        {
            this.TabPage.BeginInvoke(new Action(() =>
            {
                this.Source.Item.Action = AppItemAction.Delete;
                this.TabPage.NewAppControlOnPage(this.TabPage.AppControls.Count, this.Item);
                this.TabPage.ResumeLayout(true);
            }));
        }
    }
}
