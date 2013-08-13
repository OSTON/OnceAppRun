using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OnceRunApp.Base;
using OnceRunApp.Models; 

namespace OnceRunApp.Handlers
{
    public class GroupAddedHandler : IHandler
    {
        public GroupAddedHandler(GroupForm form)
        {
            this.Form = form;
        }

        public GroupForm Form { get; set; }

        public void Execute()
        {
            this.Form.BeginInvoke(new Action(() =>
            {
                if (this.Form.Group.Validate())
                {
                    this.Form.DialogResult = DialogResult.OK; 
                }
            }));
        }
    }
}
