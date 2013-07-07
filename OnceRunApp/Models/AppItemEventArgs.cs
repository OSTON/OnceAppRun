using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnceRunApp.Models
{
    public class AppItemEventArgs : EventArgs
    {
        public AppItemEventArgs(AppItem item)
            : base()
        {
        }
    }
}
