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

using OnceRunApp.Base;
using OnceRunApp.Models;
using OnceRunApp.Controls;
using OnceRunApp.UIHelpers;
using OnceRunApp.Handlers;
using OnceRunApp.Services;


namespace OnceRunApp
{
    /// <summary>
    /// 
    /// </summary>
    public partial class RunForm : Form
    {
        
        //Methods

        public RunForm()
        {
            InitializeComponent();

            this.InitializeHandlers();
        }

        /// <summary>
        /// Register form and control's related event handlers,the event logic is to be contained in handlers. 
        /// </summary>
        private void InitializeHandlers()
        {
            //Form Load
            this.Load += (object sender, EventArgs e) =>
            {
                HandlerHub.Invoke(new FormStartupHandler(this));
            };

            //New AppGroup
            this.btnAddGroup.Click += (object sender, EventArgs e) =>
            {
                HandlerHub.Invoke(new AppGroupHandler(this, GroupAction.New));
            };

            //Edit AppGroup
            this.btnEditGroup.Click += (object sender, EventArgs e) =>
            {
                HandlerHub.Invoke(new AppGroupHandler(this, GroupAction.Edit));
            };

            //Delete AppGroup
            this.btnRemoveGroup.Click += (object sender, EventArgs e) =>
            {
                HandlerHub.Invoke(new AppGroupHandler(this, GroupAction.Delete));
            };

            //AppGroup Shortcut
            this.btnShortcut.Click += (object sender, EventArgs e) =>
            {
                HandlerHub.Invoke(new AppGroupHandler(this, GroupAction.Shortcut));
            };

            //Run AppGroup
            this.btnRunApps.Click += (object sender, EventArgs e) =>
            {
                HandlerHub.Invoke(new AppGroupHandler(this, GroupAction.Run));
            };

            //About me
            this.btnAbout.Click += (object sender, EventArgs e) =>
            {
                HandlerHub.Invoke(new AboutMeHandler(this));
            };
        }

        
        //Properties

        public TabControl AppGroupTab
        {
            get
            {
                return this.tabAppGroup;
            }
        }
        
        public AppGroupTabPage CurrentPage
        {
            get
            {
                return this.tabAppGroup.SelectedTab as AppGroupTabPage;
            }
        }
        
    }
}
