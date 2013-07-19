﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Windows.Forms;
using OnceRunApp.Controls;
using OnceRunApp.Models;
using OnceRunApp.Utilities;

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
            panel.RowCount = KVSettings.MaxAppCount;
            panel.ColumnCount = 1;
            panel.Dock = DockStyle.Fill;
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panel.BackColor = System.Drawing.SystemColors.ControlLightLight ;

            return panel;
        }

    }
}