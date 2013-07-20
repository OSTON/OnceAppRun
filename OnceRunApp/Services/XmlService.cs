using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml.Linq;

namespace OnceRunApp.Services
{
    public class XmlService
    {
        public static XDocument LoadAppData()
        {
            return XDocument.Load("AppSetting.xml");
        }

        public static void SaveAppData(XDocument xmlSource)
        {
            xmlSource.Save("AppSetting.xml");
        }
    }
}
