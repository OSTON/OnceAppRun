using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OnceRunApp.Base;
using OnceRunApp.Controls;
using OnceRunApp.Models;


/**
 * @AUTHOR: OSTON BETTER     @EMAIL:  OSTONBETTER@GMAIL.COM
 * */


namespace OnceRunApp.UIHelpers
{
    public class UiFactory
    {

        public static TableLayoutPanel CreateTableLayoutPanel()
        {
            TableLayoutPanel panel = new TableLayoutPanel();
            panel.RowCount = GlobalVars.MaxAppCountInGroup;
            panel.ColumnCount = 1;
            panel.Dock = DockStyle.Fill;
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            //panel.BackColor = System.Drawing.SystemColors.ControlLight ;

            return panel;
        }

    }
}
