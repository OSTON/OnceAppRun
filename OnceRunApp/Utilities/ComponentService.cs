using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace OnceRunApp.Utilities
{
    public class ComponentService
    {
        public static void RegiesterNotificationEvents(IComponentChangeService componentChangeService)
        {
            if (componentChangeService != null)
            {
                componentChangeService.ComponentChanged += ComponentChangeService_ComponentChanged;
            }

        }

        public static void ClearNotificationEvents(IComponentChangeService componentChangeService)
        {
            if (componentChangeService != null)
            {
                componentChangeService.ComponentChanged -= ComponentChangeService_ComponentChanged;
            }
        }

        static void ComponentChangeService_ComponentChanged(object sender, ComponentChangedEventArgs e)
        {
            if (e.Component != null && ((IComponent)e.Component).Site != null && e.Member != null)
            {
                //OnUserChange("The " + ce.Member.Name + " member of the " + ((IComponent)ce.Component).Site.Name + " component has been changed.");
            }
        }
    }
}
