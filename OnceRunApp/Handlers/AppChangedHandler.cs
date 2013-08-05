using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OnceRunApp.Base;
using OnceRunApp.Models;
using OnceRunApp.Controls;
using OnceRunApp.Services;

namespace OnceRunApp.Handlers
{
    public class AppChangedHandler : IHandler
    {
        public AppChangedHandler(AppTabPage tabPage,AppItem item)
        {
            this.TabPage = tabPage;
            this.Item = item;
        }

        public AppTabPage TabPage { get; set; }
        public AppItem Item { get; set; }

        public void Execute()
        {
            this.TabPage.BeginInvoke(new Action(() =>
            {
                this.Item.Group = this.TabPage.Group;
                AppService.ChangeAppItem(this.Item);

            }));
        }
    }
}
