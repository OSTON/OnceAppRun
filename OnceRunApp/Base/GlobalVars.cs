using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
using System.Reflection;
using System.Configuration;

namespace OnceRunApp.Base
{
    /// <summary>
    /// Application global variables
    /// </summary>
    public class GlobalVars
    {
        /// <summary>
        /// Application execution directory.
        /// </summary>
        public static string Root
        {
            get
            {
               return Uri.UnescapeDataString(new UriBuilder(Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase)).Path);
            }
        }

        /// <summary>
        /// Applicaton data file.
        /// </summary>
        public static string DataFile
        {
            get
            {
                return Path.Combine(GlobalVars.Root, "AppSetting.xml");
            }
        }

        /// <summary>
        /// Application data instance,we sava data as xml format.
        /// </summary>
        public static XDocument SourceData
        {
            get
            {
                return XDocument.Load(GlobalVars.DataFile);
            }
        }

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
