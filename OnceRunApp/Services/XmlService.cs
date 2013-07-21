using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Xml.Linq;
using System.Reflection;

namespace OnceRunApp.Services
{
    public class XmlService
    {
        private static string AppRootUri
        {
            get
            {
                return Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
            }
        }

        public static XDocument LoadAppData()
        {
            return XDocument.Load(Path.Combine(AppRootUri, "AppSetting.xml"));
        }

        public static void SaveAppData(XDocument xmlSource)
        {
            UriBuilder uri = new UriBuilder(AppRootUri);
            xmlSource.Save(Path.Combine(Uri.UnescapeDataString(uri.Path), "AppSetting.xml"));
        }
    }
}
