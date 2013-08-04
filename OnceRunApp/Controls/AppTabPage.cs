using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OnceRunApp.Base;
using OnceRunApp.Models;
using OnceRunApp.Services;

namespace OnceRunApp.Controls
{
    public class AppTabPage : TabPage
    {
        public AppTabPage()
            : base()
        {
            this.AppControls = new List<AppControl>();
            this.InitializeContainers();
        }

        public AppTabPage(AppGroup group)
            : base()
        {
            this.Group = group;
            this.AppControls = new List<AppControl>();
            this.InitializeContainers();

            this.BindDataSource(group);
        }

        //Properties

        public int AppIndex { get;private set; }
        public AppGroup Group { get; set; }
        public TableLayoutPanel TableLayout { get;private set; }
        public List<AppControl> AppControls { get; set; }

        #region Control Init

        private void BindDataSource(AppGroup group)
        {
       
            //this.AutoScroll = true;
            this.DataBindings.Add(new Binding("Tag", this.Group, "Id"));
            this.DataBindings.Add(new Binding("Text", this.Group, "Name"));
            this.DataBindings.Add(new Binding("ToolTipText",this.Group,"Description"));
         
            this.BindAppControls(group);
        }

        private void BindAppControls(AppGroup group)
        {
            this.AppIndex = 0;          
            foreach (AppItem item in group.AppItems)
            {
                item.Action = SetNextItemAction(group.AppItems.Count);
                AppControl control = NewAppControl(item, this.AppIndex);
                this.AppControls.Add(control);
                this.TableLayout.Controls.Add(control, 0, this.AppIndex);
                this.AppIndex = SetNextAppIndex();
            }
            this.Controls.Add(this.TableLayout);
            this.ResumeLayout(true);
        }

        private int SetNextAppIndex()
        {
            int index = this.AppIndex + 1;
            return index >= GlobalVars.MaxAppCountInGroup - 1 ? GlobalVars.MaxAppCountInGroup - 1 : index;
        }

        private AppItemAction SetNextItemAction(int controlCount)
        {
            if (controlCount == GlobalVars.MaxAppCountInGroup)
            {
                return AppItemAction.Delete;
            }
            return (controlCount - 1) == this.AppIndex ? AppItemAction.All : AppItemAction.Delete;
        }

        private AppControl NewAppControl(AppItem item,int index)
        {
            AppControl control = new AppControl(item);
            control.Index = index;
            control.OnAppItemAdded += Control_OnAppItemAdded;
            control.OnAppItemRemoved += Control_OnAppItemRemoved;
            control.OnAppItemChanged += Control_OnAppItemChanged;

            return control;
        }
   
        #endregion

        #region Data Events
        
        #endregion

        #region Event Handlers

        private void Control_OnAppItemAdded(object sender, AppItemEventArgs e)
        {
            this.AddAppControlItem(sender as AppControl,e);
        }

        private void AddAppControlItem(AppControl source,AppItemEventArgs e)
        {          
            this.AppIndex = SetNextAppIndex();
            e.Item.Action = (this.AppControls.Count >= GlobalVars.MaxAppCountInGroup - 1) ? AppItemAction.Delete : AppItemAction.All;
            source.Item.Action = AppItemAction.Delete;
            AppControl control = NewAppControl(e.Item, this.AppIndex);

            this.AppControls.Add(control);
            this.TableLayout.Controls.Add(control, 0, this.AppIndex);
            this.TableLayout.ResumeLayout(true);
        }

        private void Control_OnAppItemChanged(object sender, AppItemChangedEventArgs e)
        {
            ChangeAppItem(e);
        }

        private void ChangeAppItem( AppItemChangedEventArgs e)
        {
            e.Item.Group = this.Group;
            AppService.ChangeAppItem(e.Item);
        }

        private void Control_OnAppItemRemoved(object sender, AppItemEventArgs e)
        {
            this.RemoveAppControlItem(sender as AppControl);
        }

        private void RemoveAppControlItem(AppControl control)
        {
            //logic

            if (this.AppControls.Count == 1)
            {
                MessageBox.Show("There must be have more than 1 item!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.AppControls.Remove(control))
            {
                this.TableLayout.Controls.Remove(control);
                if (AppService.ExistsAppItem(control.Item))
                {
                    AppService.RemoveAppItem(control.Item);
                }
                this.ResetAppControlsLayout();
            }
           
        }

        private void ResetAppControlsLayout()
        {
            this.AppIndex = 0;
            this.AppControls.Sort(AppControlComparison);
            
            foreach (AppControl control in this.AppControls)
            {
                this.TableLayout.SetColumn(control, 0);
                this.TableLayout.SetRow(control, this.AppIndex);
                control.Index = this.AppIndex;
                control.Item.Action = SetNextItemAction(this.AppControls.Count);
                this.AppIndex = SetNextAppIndex();
            }

            this.TableLayout.ResumeLayout(true);
        }

        private int AppControlComparison(AppControl source, AppControl target)
        {
            if (source.Index > target.Index)
            {
                return 1;
            }
            if (source.Index < target.Index)
            {
                return -1;
            }

            return 0;
        }
        
        #endregion

        private void InitializeContainers()
        {
            this.TableLayout = new TableLayoutPanel()
            {
                RowCount = GlobalVars.MaxAppCountInGroup,
                ColumnCount = 1,
                Dock = DockStyle.Fill
            };
            this.TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.Controls.Add(this.TableLayout);
        }

    }
}
