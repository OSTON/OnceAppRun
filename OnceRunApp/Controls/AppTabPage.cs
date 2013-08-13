using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OnceRunApp.Base;
using OnceRunApp.Models;
using OnceRunApp.Handlers;
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
            this.InitializeHandlers();
        }

        public AppTabPage(AppGroup group)
            : base()
        {
            this.Group = group;
            this.AppControls = new List<AppControl>();
            this.InitializeContainers();
            this.InitializeHandlers();
        }

        //Properties

        public int AppIndex { get;private set; }
        public AppGroup Group { get; set; }
        public TableLayoutPanel TableLayout { get;private set; }
        public List<AppControl> AppControls { get;private set; }


        private void InitializeHandlers()
        {
            this.HandleCreated += (object sender, EventArgs e) =>
            {
                HandlerHub.Invoke(new GroupTabLoadHandler(this));   
            };
                    
        }

        private void InitializeContainers()
        {
            this.TableLayout = new TableLayoutPanel()
            {
                RowCount = GlobalVars.AppControlCountOnPage,
                ColumnCount = 1,
                Dock = DockStyle.Fill
            };
            this.TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.Controls.Add(this.TableLayout);
        }

        public void NewAppControlOnPage(int index,AppItem item)
        {
            int itemCount = index + 1;
            bool deleteActionFlag = (itemCount < this.Group.AppItems.Count)
                                    || (itemCount == GlobalVars.AppControlCountOnPage);
            item.Action = deleteActionFlag ? AppItemAction.Delete : AppItemAction.All;

            AppControl control = new AppControl(item);
            control.Index = index;
            //App Added
            control.OnAppItemAdded += (object sender, AppItemEventArgs e) =>
            {
                HandlerHub.Invoke(new AppAddedHandler(this, sender as AppControl, e.Item));
            };
            //App Removed
            control.OnAppItemRemoved += (object sender, AppItemEventArgs e) =>
            {
                HandlerHub.Invoke(new AppRemovedHandler(this, sender as AppControl));
            };
            //App Changed
            control.OnAppItemChanged += (object sender, AppItemChangedEventArgs e)=>
            {
                HandlerHub.Invoke(new AppChangedHandler(this, e.Item));
            };

            this.AppControls.Add(control);
            this.TableLayout.Controls.Add(control, 0, index);
        }
    }
}
