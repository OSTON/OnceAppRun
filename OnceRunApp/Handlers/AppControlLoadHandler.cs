using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OnceRunApp.Base;
using OnceRunApp.Models;
using OnceRunApp.Controls;
using System.ComponentModel;

namespace OnceRunApp.Handlers
{
    public class AppControlLoadHandler : IHandler
    {
        public AppControlLoadHandler(AppControl control)
        {
            this.Control = control;
        }

        public AppControl Control { get; set; }

        public void Execute()
        {
            this.Control.BeginInvoke(new Action(() =>
            {
                this.Control.Dock = DockStyle.Fill;

                this.Control.DataBindings.Add(new Binding("Tag", this.Control.Item, "Id"));
                this.Control.NameTextBox.DataBindings.Add(new Binding("Text", this.Control.Item, "Name"));
                this.Control.ExePathTextBox.DataBindings.Add(new Binding("Text", this.Control.Item, "ExePath"));

                this.Control.DisplayActionButtons(this.Control.Item);
            }));
        }


    }
}
