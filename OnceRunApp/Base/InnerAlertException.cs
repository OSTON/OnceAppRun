using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnceRunApp.Base
{
    public class InnerAlertException : Exception
    {
        public InnerAlertException(string message,AlertType type)
            : base(message)
        {
            this.Type = type;
        }

        public AlertType Type { get; set; }
    }
}
