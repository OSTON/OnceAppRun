using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NLog;

namespace OnceRunApp.Base
{
    public class MyLogger : Logger
    {
        private readonly static Logger myLogger = LogManager.GetCurrentClassLogger(typeof(MyLogger));

        public static Logger Instance
        {
            get
            {
                return myLogger;
            }
        }
    }
}
