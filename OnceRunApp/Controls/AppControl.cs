using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;

using OnceRunApp.Models;

/**
 * @AUTHOR: OSTON BETTER     @EMAIL:  OSTONBETTER@GMAIL.COM
 * */


namespace OnceRunApp.Controls
{
    /// <summary>
    /// App control contains
    /// 1.application execution file path and target application name
    /// 2.provide some events to handle application settings,e.g:add,remove,delete event 
    /// user can setting application and register events by this control
    /// </summary>
    public partial class AppControl : UserControl
    {
        public AppControl()
        {
            InitializeComponent();
        }

        public AppControl(AppItem item)
        {
            InitializeComponent();

            this.BindDataSource(item);
            this.BindDataEvents();
        }

        //Properties

        public AppItem Item { get; set; }

        //Events

        public delegate void OnAppItemAddedHandler(object sender,AppItemEventArgs e);
        public delegate void OnAppItemRemovedHandler(object sender,AppItemEventArgs e);
        public delegate void OnAppItemChangedHandler(object sender, AppItemChangedEventArgs e);

        public event OnAppItemAddedHandler OnAppItemAdded;
        public event OnAppItemRemovedHandler OnAppItemRemoved;
        public event OnAppItemChangedHandler OnAppItemChanged;

        #region Control Init

        private void BindDataSource(AppItem item)
        {
            this.Item = item;

            this.txtName.DataBindings.Add(new Binding("Text", this.Item, "Name"));
            this.txtExePath.DataBindings.Add(new Binding("Text", this.Item, "ExePath"));

            switch (item.Action)
            {
                case AppItemAction.All:
                    this.btnRemove.Visible = true;
                    this.btnAdd.Visible = true;
                    break;
                case AppItemAction.Add:
                    this.btnRemove.Visible = false;
                    this.btnAdd.Visible = true;
                    break;
                case AppItemAction.Delete:
                    this.btnAdd.Visible = false;
                    this.btnRemove.Visible = true;
                    break;
            }
        }

        private void BindDataEvents()
        {
            this.Item.PropertyChanged += OnDataPropertyChanged;
        }

        private void OnDataPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //MessageBox.Show(e.PropertyName + " is changed");
            if (OnAppItemChanged != null)
            {
                OnAppItemChanged(sender, new AppItemChangedEventArgs(this.Item, e.PropertyName));
            }
        }
        #endregion

        #region Button Operations

        private void BtnChooseExe_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "EXE Files(*.exe)|*.exe|All Files|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtExePath.Text = this.Item.ExePath = fileDialog.FileName;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (OnAppItemAdded != null)
            {
                OnAppItemAdded(sender, new AppItemEventArgs(this.Item));
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (OnAppItemRemoved != null)
            {
                OnAppItemRemoved(sender, new AppItemEventArgs(this.Item));
            }
        }
        
        #endregion

    }
}
