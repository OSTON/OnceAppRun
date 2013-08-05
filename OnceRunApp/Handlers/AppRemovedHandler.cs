using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OnceRunApp.Base;
using OnceRunApp.Models;
using OnceRunApp.Controls;
using OnceRunApp.Services;

namespace OnceRunApp.Handlers
{
    public class AppRemovedHandler : IHandler
    {
        public AppRemovedHandler(AppTabPage tabPage,AppControl control)
        {
            this.TabPage = tabPage;
            this.Control = control;
        }

        public AppTabPage TabPage { get; set; }
        public AppControl Control { get; set; }


        public void Execute()
        {
            this.TabPage.BeginInvoke(new Action(() =>
            {
                if (this.TabPage.AppControls.Count == 1)
                {
                    throw new MyAlertException("There must be have more than 1 item!");
                }

                if (this.TabPage.AppControls.Remove(this.Control))
                {
                    this.TabPage.TableLayout.Controls.Remove(this.Control);
                    if (AppService.ExistsAppItem(this.Control.Item))
                    {
                        AppService.RemoveAppItem(this.Control.Item);
                    }

                    int index = 0;
                    this.TabPage.AppControls.Sort(ControlComparison);
                    foreach (AppControl control in this.TabPage.AppControls)
                    {
                        this.TabPage.TableLayout.SetColumn(control, 0);
                        this.TabPage.TableLayout.SetRow(control, index);
                        control.Index = index;
                        int itemCount = index + 1;
                        bool deleteActionFlag = (itemCount < this.TabPage.AppControls.Count)
                                                || (itemCount == GlobalVars.AppControlCountOnPage);
                        control.Item.Action = deleteActionFlag ? AppItemAction.Delete : AppItemAction.All;
                        ++index;
                    }
                    this.TabPage.ResumeLayout(true);
                }

            }));
        }


        private int ControlComparison(AppControl source, AppControl target)
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
    }
}
