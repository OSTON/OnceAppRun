using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NLog;

namespace OnceRunApp.Services
{
    public class LogService
    {
        private LogService() { }

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
