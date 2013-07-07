using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Windows.Forms;
using OnceRunApp.Controls;
using OnceRunApp.Models;

/**
 * @AUTHOR: OSTON BETTER     @EMAIL:  OSTONBETTER@GMAIL.COM
 * */


namespace OnceRunApp.UIHelpers
{
    public class UICreator
    {

        public static AppControl CreateAppControl(AppItem item)
        {
            AppControl control = new AppControl(item);
            control.Dock = DockStyle.Fill;
            //control.BackColor = System.Drawing.Color.Blue;

            return control;
        }

        public static TableLayoutPanel CreateTableLayoutPanel()
        {
            TableLayoutPanel panel = new TableLayoutPanel();
            panel.RowCount = 10;
            panel.ColumnCount = 1;
            panel.Dock = DockStyle.Fill;
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            return panel;
        }

        public static void CreateTabPage(TabControl control,AppGroup group)
        {
            TabPage tabPage = new TabPage();
            tabPage.Tag = group.Id;
            tabPage.Text = group.Name;
            tabPage.AutoScroll = true;

            int count = 0;
            TableLayoutPanel panel = CreateTableLayoutPanel();
            foreach (AppItem item in group.AppItems)
            {
                panel.Controls.Add(CreateAppControl(item),count,count);
                ++count;
            }

            tabPage.Controls.Add(panel);
            control.Controls.Add(tabPage);
            control.ResumeLayout(true);
        }
    }
}
