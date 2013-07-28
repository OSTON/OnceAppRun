using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnceRunApp.Models
{
    public class AppItemChangedEventArgs : AppItemEventArgs
    {
        public AppItemChangedEventArgs(AppItem item, string propertyName)
            : base(item)
        {
            this.Item = item;
            this.PropertyName = propertyName;
        }

        public AppItem Item { get; set; }
        public string PropertyName { get; set; }
    }
}
