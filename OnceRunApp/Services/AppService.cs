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
        public static List<AppGroup> GetAppGroups()
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

        public static List<AppItem> GetAppItems(XElement xGroup)
        {
            var result = from e in xGroup.Descendants("App")
                         select new AppItem()
                         {
                             Id = e.Attribute("Id").Value,
                             Name = e.Attribute("Name").Value,
                             ExePath = e.Attribute("ExePath").Value
                         };
            return result != null ? result.ToList<AppItem>() : new List<AppItem>();           
        }

        public static bool ExistsAppGroup(AppGroup group)
        {
            XDocument xmlSource = XmlUtil.GetAppXmlData();
            var result = xmlSource.Descendants("Group").Where(g => g.Attribute("Id").Value.Equals(group.Id));
            return result != null && result.Count() > 0;
        }

        public static bool ExistsAppItem(AppItem item)
        {
            XDocument xmlSource = XmlUtil.GetAppXmlData();
            var result = xmlSource.Descendants("App").Where(a => a.Attribute("Id").Value.Equals(item.Id));
            return result != null && result.Count() > 0;
        }

        public static void AddAppGroup(AppGroup group)
        {
            XDocument xmlSource = XmlUtil.GetAppXmlData();

            XElement xGroup = new XElement("Group");
            xGroup.SetAttributeValue("Id", group.Id);
            xGroup.SetAttributeValue("Name", group.Name);
            foreach (AppItem item in group.AppItems)
            {
                XElement xApp = new XElement("App");
                xApp.SetAttributeValue("Id", item.Id);
                xApp.SetAttributeValue("Name", item.Name);
                xApp.SetAttributeValue("ExePath", item.ExePath);

                xGroup.Add(xApp);
            }

            xmlSource.Element("Apps").Add(xGroup);
            XmlUtil.SaveAppXmlData(xmlSource);
        }

        public static void UpdateAppGroup(AppGroup group)
        {
            XDocument xmlSource = XmlUtil.GetAppXmlData();
            XElement xGroup = xmlSource.Descendants("Group").FirstOrDefault(g => g.Attribute("Id").Value.Equals(group.Id));
            if (xGroup != null)
            {
                xGroup.SetAttributeValue("Name", group.Name);
                XmlUtil.SaveAppXmlData(xmlSource);
            }
        }

        public static void RemoveAppGroup(AppGroup group)
        {
            XDocument xmlSource = XmlUtil.GetAppXmlData();
            XElement xGroup = xmlSource.Descendants("Group").FirstOrDefault(g => g.Attribute("Id").Value.Equals(group.Id));
            if (xGroup != null)
            {
                xGroup.Remove();
                XmlUtil.SaveAppXmlData(xmlSource);
            }           
        }

        public static void ChangeAppItem(AppItem item)
        {
            if (ExistsAppItem(item))
            {
                UpdateAppItem(item);
            }
            else
            {
                AddAppItem(item);
            }
        }

        public static void AddAppItem(AppItem item)
        {
            XDocument xmlSource = XmlUtil.GetAppXmlData();
            XElement xGroup = xmlSource.Descendants("Group").FirstOrDefault(g => g.Attribute("Id").Value.Equals(item.Group.Id) && g.Attribute("Name").Value.Equals(item.Group.Name));
            
            XElement xApp = new XElement("App");
            xApp.SetAttributeValue("Id", item.Id);
            xApp.SetAttributeValue("Name", item.Name);
            xApp.SetAttributeValue("ExePath", item.ExePath);

            xGroup.Add(xApp);
            XmlUtil.SaveAppXmlData(xmlSource);
        }

        public static void UpdateAppItem(AppItem item)
        {
            XDocument xmlSource = XmlUtil.GetAppXmlData();
            XElement xApp = xmlSource.Descendants("App").FirstOrDefault(a => a.Attribute("Id").Value.Equals(item.Id));
            if (xApp != null)
            {
                xApp.SetAttributeValue("Name", item.Name);
                xApp.SetAttributeValue("ExePath", item.ExePath);
                XmlUtil.SaveAppXmlData(xmlSource);
            }
        }

        public static void RemoveAppItem(AppItem item)
        {
            XDocument xmlSource = XmlUtil.GetAppXmlData();
            XElement xApp = xmlSource.Descendants("App").FirstOrDefault(a => a.Attribute("Id").Value.Equals(item.Id));
            if (xApp != null)
            {
                xApp.Remove();
                XmlUtil.SaveAppXmlData(xmlSource);
            }
        }

    }
}
