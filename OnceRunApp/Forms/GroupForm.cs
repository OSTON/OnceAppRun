using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OnceRunApp.Models;

namespace OnceRunApp
{
    public partial class GroupForm : Form
    {
        public GroupForm()
        {
            InitializeComponent();
        }

        public GroupForm(FormAction action)
            : base()
        {
            InitializeComponent();
            this.Action = action;
        }

        
        public AppGroup Group { get; set; }
        public FormAction Action { get; set; }

        #region Form Init

        private void GroupForm_Load(object sender, EventArgs e)
        {
            this.InitDataSource();
            this.HightlightInput();
        }
        private void InitDataSource()
        {
            if (this.Action == FormAction.NewItem)
            {
                this.Group = new AppGroup("");
            }

            this.txtGroupName.DataBindings.Add(new Binding("Text", this.Group, "Name"));
        }

        private void HightlightInput()
        {
            if (this.Action == FormAction.NewItem)
            {
                this.ActiveControl = this.txtGroupName;
                this.txtGroupName.Focus();
            }
            if (this.Action == FormAction.EditItem)
            {
                this.txtGroupName.SelectionStart = 0;
                this.txtGroupName.SelectionLength = this.Name.Length;
                this.txtGroupName.Select();
            }
        }

        #endregion

        #region Button Event Handlers

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        #endregion

    }
}
