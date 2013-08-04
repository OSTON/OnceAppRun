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
    public class AppChoosedHandler : IHandler
    {
        public AppChoosedHandler(AppControl control)
        {
            this.Control = control;
        }

        public AppControl Control { get; set; }

        public void Execute()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "EXE Files(*.exe)|*.exe|All Files|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.Control.Item.ExePath = fileDialog.FileName;
            }
        }
    }
}
