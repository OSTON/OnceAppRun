using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;

namespace OnceRunApp.Configs
{
    public class KVSettings
    {
        public static int MaxAppCountInGroup
        {
            get
            {
                int appCount = 10;
                int.TryParse(ConfigurationManager.AppSettings["MaxAppCountInGroup"], out appCount);
                return appCount;
            }
        }

        public static int MaxGroupCountOnPage
        {
            get
            {
                int groupCount = 50;
                int.TryParse(ConfigurationManager.AppSettings["MaxGroupCountOnPage"], out groupCount);
                return groupCount;
            }
        }

        public static int AppRunIntervalTime
        {
            get
            {
                int intervalTime = 0;
                int.TryParse(ConfigurationManager.AppSettings["AppIntervalRunTime"], out intervalTime);
                return intervalTime;
            }
        }
    }
}
