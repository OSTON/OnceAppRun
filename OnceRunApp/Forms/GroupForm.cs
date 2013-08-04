using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OnceRunApp.Base;
using OnceRunApp.Models;
using OnceRunApp.Handlers;

namespace OnceRunApp
{
    public partial class GroupForm : Form
    {
        public GroupForm()
        {
            InitializeComponent();

            this.InitializeHandlers();
        }

        public GroupForm(BaseAction action)
        {
            InitializeComponent();
            this.Action = action;
            this.InitializeHandlers();
        }


        public AppGroup Group { get; set; }
        public BaseAction Action { get; set; }
        public TextBox NameTextBox
        {
            get
            {
               return this.txtGroupName;
            }
        }
        public TextBox DescriptionTextBox
        {
            get
            {
                return this.textBox1;
            }
        }
        public PictureBox FlagPictureBox
        {
            get
            {
                return this.pbTitle;
            }
        }


        public void InitializeHandlers()
        {
            //Form Load
            this.Load += (object sender, EventArgs e) =>
            {
                HandlerHub.Invoke(new GroupFormLoadHandler(this));
            };

            //Add Group
            this.btnOK.Click += (object sender, EventArgs e) =>
            {
                HandlerHub.Invoke(new GroupAddedHandler(this));
            };
        }

    }
}
