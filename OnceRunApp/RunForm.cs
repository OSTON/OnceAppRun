using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OnceRunApp.Models;
using OnceRunApp.Controls;
using OnceRunApp.Utilities;
using OnceRunApp.UIHelpers;
using OnceRunApp.Services;


namespace OnceRunApp
{
    /// <summary>
    /// 
    /// </summary>
    public partial class RunForm : Form
    {
        public RunForm()
        {
            InitializeComponent();
        }

        //Properties

        #region Form Init

        private void RunForm_Load(object sender, EventArgs e)
        {
            this.BingDataSource();
        }

        private void BingDataSource()
        {
            foreach (AppGroup group in AppService.GetAppGroups())
            {
                this.tabAppGroup.Controls.Add(new AppGroupTabPage(group));
            }

           this.tabAppGroup.ResumeLayout(true);
        }        
        #endregion

        #region Button Event Handlers

        private void BtnAddGroup_Click(object sender, EventArgs e)
        {
            AddAppGroup();
        }

        private void AddAppGroup()
        {
            GroupForm form = new GroupForm(FormAction.NewItem);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                AppService.AddAppGroup(form.Group);
                this.tabAppGroup.Controls.Add(new AppGroupTabPage(form.Group));
                this.tabAppGroup.ResumeLayout(true);
            }
        }

        private void BtnEditGroup_Click(object sender, EventArgs e)
        {
            EditAppGroup();
        }

        private void EditAppGroup()
        {
            AppGroupTabPage tabPage = this.tabAppGroup.SelectedTab as AppGroupTabPage;
            if (tabPage != null)
            {
                GroupForm form = new GroupForm(FormAction.EditItem);
                form.Group = tabPage.Group;
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    AppService.UpdateAppGroup(form.Group);
                    tabPage.Group = form.Group;
                }
            }
        }

        private void BtnRemoveGroup_Click(object sender, EventArgs e)
        {
            RemoveAppGroup();
        }

        private void RemoveAppGroup()
        {
            AppGroupTabPage tabPage = this.tabAppGroup.SelectedTab as AppGroupTabPage;
            if (tabPage != null)
            {
                if (UiMessager.Confirm("Are you sure to remove current group?") == System.Windows.Forms.DialogResult.Yes)
                {
                    AppService.RemoveAppGroup(tabPage.Group);
                    this.tabAppGroup.Controls.Remove(tabPage);
                    this.tabAppGroup.ResumeLayout(true);
                }
            }
        }

        #endregion




    }
}
