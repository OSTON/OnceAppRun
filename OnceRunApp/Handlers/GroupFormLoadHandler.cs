using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OnceRunApp.Base;
using OnceRunApp.Models;

namespace OnceRunApp.Handlers
{
    public class GroupFormLoadHandler : IHandler
    {

        public GroupFormLoadHandler(GroupForm form)
        {
            this.Form = form;
        }

        public GroupForm Form { get; set; }

        public void Execute()
        {
            this.Form.BeginInvoke(new Action(() =>
            {

                if (this.Form.Action == BaseAction.New)
                {
                    this.Form.Group = new AppGroup(string.Empty);
                }
                this.Form.NameTextBox.DataBindings.Add(new Binding("Text", this.Form.Group, "Name"));
                this.Form.DescriptionTextBox.DataBindings.Add(new Binding("Text", this.Form.Group, "Description"));

                switch (this.Form.Action)
                {
                    case BaseAction.New:

                        this.Form.Text = "Add Group";
                        this.Form.ActiveControl = this.Form.NameTextBox;
                        this.Form.NameTextBox.Focus();
                        this.Form.FlagPictureBox.Image = OnceRunApp.Properties.Resources.tab_add;
                        break;
                    case BaseAction.Edit:

                        this.Form.Text = "Edit Group";
                        this.Form.ActiveControl = this.Form.NameTextBox;
                        this.Form.NameTextBox.SelectAll();
                        this.Form.FlagPictureBox.Image = OnceRunApp.Properties.Resources.tab_edit;
                        break;
                }

            }));
            
        }
    }
}
