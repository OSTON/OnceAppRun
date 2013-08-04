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

using OnceRunApp.Base;
using OnceRunApp.Models;
using OnceRunApp.Handlers;

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

            this.InitializeHandlers();
        }

        public AppControl(AppItem item)
        {
            InitializeComponent();
            this.Item = item;
            this.InitializeHandlers();
        }

        //Properties

        public int Index { get; set; }
        public AppItem Item { get; set; }
        public TextBox NameTextBox
        {
            get
            {
                return this.txtName;
            }
        }
        public TextBox ExePathTextBox
        {
            get
            {
                return this.txtExePath;
            }
        }
        public Button AddButton
        {
            get
            {
                return this.btnAdd;
            }
        }
        public Button RemoveButton
        {
            get
            {
                return this.btnRemove;
            }
        }

        //Events

        public delegate void OnAppItemAddedHandler(object sender,AppItemEventArgs e);
        public delegate void OnAppItemRemovedHandler(object sender,AppItemEventArgs e);
        public delegate void OnAppItemChangedHandler(object sender, AppItemChangedEventArgs e);

        public event OnAppItemAddedHandler OnAppItemAdded;
        public event OnAppItemRemovedHandler OnAppItemRemoved;
        public event OnAppItemChangedHandler OnAppItemChanged;


        public void InitializeHandlers()
        {
            //Control Load
            this.Load += (object sender, EventArgs e) =>
            {
                HandlerHub.Invoke(new AppControlLoadHandler(this));
            };

            //Data Changed
            this.Item.PropertyChanged += (object sender, PropertyChangedEventArgs e) =>
            {
                if (e.PropertyName.Equals("Action"))
                {
                    this.DisplayActionButtons(this.Item);
                    return;
                }

                if (OnAppItemChanged != null)
                {
                    OnAppItemChanged(sender, new AppItemChangedEventArgs(this.Item, e.PropertyName));
                }
            };


            this.AddButton.Click += (object sender, EventArgs e) =>
            {
                if (OnAppItemAdded != null)
                {
                    OnAppItemAdded(this, new AppItemEventArgs(new AppItem()));
                }
            };

            this.RemoveButton.Click += (object sender, EventArgs e) =>
            {
                if (OnAppItemRemoved != null)
                {
                    OnAppItemRemoved(this, new AppItemEventArgs(this.Item));
                }
            };

            this.btnChooseExe.Click += (object sender, EventArgs e) =>
            {
                HandlerHub.Invoke(new AppChoosedHandler(this));
            };
        }

        public void DisplayActionButtons(AppItem item)
        {
            switch (item.Action)
            {
                case AppItemAction.All:
                    this.RemoveButton.Visible = true;
                    this.AddButton.Visible = true;
                    break;
                case AppItemAction.Add:
                    this.RemoveButton.Visible = false;
                    this.AddButton.Visible = true;
                    break;
                case AppItemAction.Delete:
                    this.AddButton.Visible = false;
                    this.RemoveButton.Visible = true;
                    break;
            }
        }

    }
}
