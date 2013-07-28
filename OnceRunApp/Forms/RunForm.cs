﻿using System;
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
using OnceRunApp.Configs;
using OnceRunApp.UIHelpers;
using OnceRunApp.Utilities;
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
        public AppGroupTabPage CurrentTab
        {
            get
            {
                return this.tabAppGroup.SelectedTab as AppGroupTabPage;
            }
        }

        #region Form Init

        private void RunForm_Load(object sender, EventArgs e)
        {
            this.BindDataSource();
            this.BindAppRunEvents();
        }

        private void BindDataSource()
        {
            foreach (AppGroup group in AppService.GetAppGroups())
            {
                this.tabAppGroup.Controls.Add(new AppGroupTabPage(group));
            }

           this.tabAppGroup.ResumeLayout(true);
        }

        private void BindAppRunEvents()
        {
            AppService.OnAppRunError += AppService_OnAppRunError;
        }

        private void AppService_OnAppRunError(AppItemEventArgs e)
        {
            UiMessager.ShowError(string.Format("App [{0}] is run error,{1}!",e.Item.Name,e.Error.Message));
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
            if (form.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
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
            if (this.CurrentTab != null)
            {
                GroupForm form = new GroupForm(FormAction.EditItem);
                form.Group = this.CurrentTab.Group;
                if (form.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    AppService.UpdateAppGroup(form.Group);
                    this.CurrentTab.Group = form.Group;
                }
            }
        }

        private void BtnRemoveGroup_Click(object sender, EventArgs e)
        {
            RemoveAppGroup();
        }

        private void RemoveAppGroup()
        {
            if (this.CurrentTab != null)
            {
                if (UiMessager.ShowConfirm("Are you sure to remove current group?") == System.Windows.Forms.DialogResult.Yes)
                {
                    AppService.RemoveAppGroup(this.CurrentTab.Group);
                    this.tabAppGroup.Controls.Remove(this.CurrentTab);
                    this.tabAppGroup.ResumeLayout(true);
                }
            }
        }

        private void BtnShortcut_Click(object sender, EventArgs e)
        {
            CreateShortcut();
        }

        private void CreateShortcut()
        {
            if (this.CurrentTab != null)
            {
                ShortcutService.CreateShortcut(this.CurrentTab.Group);
                UiMessager.ShowInfo("Group shortcut is created sucessfully!");
            }
        }

        private void BtnRunApps_Click(object sender, EventArgs e)
        {
            RunSelectedApps();
        }

        private void RunSelectedApps()
        {
            if (this.CurrentTab != null)
            {
                AppService.RunApps(this.CurrentTab.Group);
            }
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.ShowDialog(this);
        }

        #endregion

    }
}
