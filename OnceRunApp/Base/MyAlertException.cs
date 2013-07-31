using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnceRunApp.Base
{
    public class MyAlertException : Exception
    {
        public MyAlertException(string message)
            : base(message)
        {
        }
    }
}
