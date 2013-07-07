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

        }
    }
}
