using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnceRunApp.Models
{
    public class AppItemEventArgs : EventArgs
    {
        public AppItemEventArgs() : base() { }

        public AppItemEventArgs(AppItem item)
            : base()
        {
            this.Item = item;
        }

        public AppItemEventArgs(AppItem item, Exception error)
            : base()
        {
            this.Item = item;
            this.Error = error;
        }


        public AppItem Item { get; set; }
        public Exception Error { get; set; }
    }
}
