using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml.Linq;

namespace OnceRunApp.Utilities
{
    public class XmlUtil
    {
        public static XDocument GetAppXmlData()
        {
            return XDocument.Load("AppSetting.xml");
        }

        public static void SaveAppXmlData(XDocument xmlSource)
        {
            xmlSource.Save("AppSetting.xml");
        }
    }
}
