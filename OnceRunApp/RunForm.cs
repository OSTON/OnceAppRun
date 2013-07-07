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
using OnceRunApp.Utilities;
using OnceRunApp.UIHelpers;
using OnceRunApp.Services;


namespace OnceRunApp
{
    /// <summary>
    /// @Author OSTON BETTER
    /// @Comment
    /// 
    /// </summary>
    public partial class RunForm : Form
    {
        public RunForm()
        {
            InitializeComponent();
        }

        private void RunForm_Load(object sender, EventArgs e)
        {

            this.BindAppGroupData();
        }

        private void BindAppGroupData()
        {
            foreach (AppGroup group in AppService.GetAppGroups())
            {
                group.AppItems.First().Action = AppItemAction.Add;
                UICreator.CreateTabPage(this.tabAppGroup, group);
            }
        }

        private void btnAddAppGroup_Click(object sender, EventArgs e)
        {
            this.CreateNewTabPage("Test");
        }

        private void CreateNewTabPage(string name)
        {
            AppGroup group = new AppGroup(name);
            UICreator.CreateTabPage(this.tabAppGroup,group);
        }
    }
}
