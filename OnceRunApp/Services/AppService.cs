using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml.Linq;
using OnceRunApp.Models;
using OnceRunApp.Utilities;

namespace OnceRunApp.Services
{
    public class AppService
    {
        public static IEnumerable<AppGroup> GetAppGroups()
        {
            XDocument xmlSource = XmlUtil.GetAppXmlData();
            var result = from e in xmlSource.Descendants("Group")
                         select new AppGroup()
                         {
                             Id = e.Attribute("Id").Value,
                             Name = e.Attribute("Name").Value,
                             AppItems = GetAppItems(e)
                         };

            return result != null ? result.ToList<AppGroup>() : new List<AppGroup>();
        }

        public static IEnumerable<AppItem> GetAppItems(XElement eApp)
        {
            var result = from e in eApp.Descendants("App")
                         select new AppItem()
                         {
                             Id = e.Attribute("Id").Value,
                             Name = e.Attribute("Name").Value,
                             ExePath = e.Attribute("ExePath").Value
                         };
            return result != null ? result.ToList<AppItem>() : new List<AppItem>();           
        }

        public static void SaveAppGroups(IEnumerable<AppGroup> groups)
        {
            XElement apps = new XElement("Apps");
            foreach (AppGroup gItem in groups)
            {
                XElement group = new XElement("Group");
                group.SetAttributeValue("Name", gItem.Name);
                foreach (AppItem aItem in gItem.AppItems)
                {
                    XElement app = new XElement("App");
                    app.SetAttributeValue("Name", aItem.Name);
                    app.SetAttributeValue("ExePath", aItem.ExePath);
                    group.Add(app);
                }
                apps.Add(group);
            }

            XmlUtil.SaveAppXmlData(new XDocument(apps));
        }
    }
}
