using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;

namespace OnceRunApp.Configs
{
    public class KVSettings
    {
        public static int MaxAppCount
        {
            get
            {
                int appCount = 10;
                int.TryParse(ConfigurationManager.AppSettings["MaxAppCount"], out appCount);
                return appCount;
            }
        }

        public static int MaxGroupCount
        {
            get
            {
                int groupCount = 50;
                int.TryParse(ConfigurationManager.AppSettings["MaxGroupCount"], out groupCount);
                return groupCount;
            }
        }
    }
}
