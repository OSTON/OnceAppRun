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

        private static Logger Logger
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

        public static void Info(string message)
        {
            Logger.Info(message);
        }

        public static void Error(string message)
        {
            Logger.Error(message);
        }

        public static void Error(string message, Exception exception)
        {
            Logger.ErrorException(message, exception);
        }

        public static void Warn(string message)
        {
            Logger.Warn(message);
        }

    }
}
