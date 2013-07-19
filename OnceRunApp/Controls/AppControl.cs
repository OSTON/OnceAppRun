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

        public int Index { get; set; }
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
            this.Dock = DockStyle.Fill;

            this.DataBindings.Add(new Binding("Tag", this.Item, "Id"));
            this.txtName.DataBindings.Add(new Binding("Text", this.Item, "Name"));
            this.txtExePath.DataBindings.Add(new Binding("Text", this.Item, "ExePath"));

            this.SetActions(item);
        }

        private void SetActions(AppItem item)
        {
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

        #endregion

        #region Data Event Handlers

        private void OnDataPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //Handle self event
            if (e.PropertyName.Equals("Action"))
            {
                SetActions(this.Item);
                return;
            }

            //Fire subscribe event listener
            if (OnAppItemChanged != null)
            {
                OnAppItemChanged(sender, new AppItemChangedEventArgs(this.Item, e.PropertyName));
            }
        }
        #endregion

        #region Button Event Handlers

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
                OnAppItemAdded(this, new AppItemEventArgs(new AppItem()));
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (OnAppItemRemoved != null)
            {
                OnAppItemRemoved(this, new AppItemEventArgs(this.Item));
            }
        }
        
        #endregion

    }
}
