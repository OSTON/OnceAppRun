using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NLog;

namespace OnceRunApp.Utilities
{
    public class AppLogger
    {
        private AppLogger() { }

        private static Logger logger;

        public static Logger Logger
        {
            get
            {
                if (logger == null)
                {
                    logger = LogManager.GetCurrentClassLogger();
                }

                return logger;
            }
        }
    }
}
