using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OnceRunApp.Models;
using OnceRunApp.UIHelpers;

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
                this.pbTitle.Image = OnceRunApp.Properties.Resources.tab_add;
                this.ActiveControl = this.txtGroupName;
                this.txtGroupName.Focus();
            }
            if (this.Action == FormAction.EditItem)
            {
                this.pbTitle.Image = OnceRunApp.Properties.Resources.tab_edit;
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

        #region Override Methods

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            System.IntPtr ptr = RoundRectangle.CreateRoundRectRegion(0, 0, this.Width, this.Height, 20, 20); // _BoarderRaduis can be adjusted to your needs, try 15 to start.
            this.Region = System.Drawing.Region.FromHrgn(ptr);
            RoundRectangle.DeleteObject(ptr);
        }

        #endregion

    }
}
