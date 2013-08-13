using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
using OnceRunApp.Base;
using OnceRunApp.Models;
using System.Diagnostics;
using System.Threading;
using Shell32;
using IWshRuntimeLibrary;
using System.Windows.Forms;



namespace OnceRunApp.Services
{
    public class AppService
    {
        //Events

        public delegate void OnAppRunErrorHandler(AppItemEventArgs e);
        public static event OnAppRunErrorHandler OnAppRunError;

        #region Base functions
       
        public static List<AppGroup> GetAppGroups()
        {
            XDocument data = GlobalVars.SourceData;
            var result = from e in data.Descendants("Group")
                         select new AppGroup()
                         {
                             Id = e.Attribute("Id").Value,
                             Name = e.Attribute("Name").Value,
                             Description = e.Attribute("Description").Value,
                             AppItems = GetAppItems(e)
                         };

            return result != null ? result.ToList<AppGroup>() : new List<AppGroup>();
        }

        public static AppGroup GetAppGroup(string id)
        {
            AppGroup group = new AppGroup(); 
            XDocument data = GlobalVars.SourceData;
            XElement xGroup = data.Descendants("Group").FirstOrDefault(g => g.Attribute("Id").Value.Equals(id));
            if (xGroup != null)
            {
                group.Id = xGroup.Attribute("Id").Value;
                group.Name = xGroup.Attribute("Name").Value;
                group.Description = xGroup.Attribute("Description").Value;
                group.AppItems = GetAppItems(xGroup);
            }

            return group;
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
            XDocument data = GlobalVars.SourceData;
            var result = data.Descendants("Group").Where(g => g.Attribute("Id").Value.Equals(group.Id));
            return result != null && result.Count() > 0;
        }

        public static bool ExistsAppItem(AppItem item)
        {
            XDocument source = GlobalVars.SourceData;
            var result = source.Descendants("App").Where(a => a.Attribute("Id").Value.Equals(item.Id));
            return result != null && result.Count() > 0;
        }

        public static void AddAppGroup(AppGroup group)
        {
            XDocument data = GlobalVars.SourceData;

            XElement xGroup = new XElement("Group");
            xGroup.SetAttributeValue("Id", group.Id);
            xGroup.SetAttributeValue("Name", group.Name);
            xGroup.SetAttributeValue("Description", group.Description);
            foreach (AppItem item in group.AppItems)
            {
                XElement xApp = new XElement("App");
                xApp.SetAttributeValue("Id", item.Id);
                xApp.SetAttributeValue("Name", item.Name);
                xApp.SetAttributeValue("ExePath", item.ExePath);

                xGroup.Add(xApp);
            }

            data.Element("Apps").Add(xGroup);
            data.SavaAsSource();
        }

        public static void UpdateAppGroup(AppGroup group)
        {
            XDocument data =GlobalVars.SourceData;
            XElement xGroup = data.Descendants("Group").FirstOrDefault(g => g.Attribute("Id").Value.Equals(group.Id));
            if (xGroup != null)
            {
                xGroup.SetAttributeValue("Name", group.Name);
                xGroup.SetAttributeValue("Description", group.Description); 
                data.SavaAsSource();
            }
        }

        public static void RemoveAppGroup(AppGroup group)
        {
            XDocument data = GlobalVars.SourceData;
            XElement xGroup = data.Descendants("Group").FirstOrDefault(g => g.Attribute("Id").Value.Equals(group.Id));
            if (xGroup != null)
            {
                xGroup.Remove();
                data.SavaAsSource();
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
            XDocument data = GlobalVars.SourceData;
            XElement xGroup = data.Descendants("Group").FirstOrDefault(g => g.Attribute("Id").Value.Equals(item.Group.Id) && g.Attribute("Name").Value.Equals(item.Group.Name));
            
            XElement xApp = new XElement("App");
            xApp.SetAttributeValue("Id", item.Id);
            xApp.SetAttributeValue("Name", item.Name);
            xApp.SetAttributeValue("ExePath", item.ExePath);

            xGroup.Add(xApp);
            data.SavaAsSource();
        }

        public static void UpdateAppItem(AppItem item)
        {
            XDocument data = GlobalVars.SourceData;
            XElement xApp = data.Descendants("App").FirstOrDefault(a => a.Attribute("Id").Value.Equals(item.Id));
            if (xApp != null)
            {
                xApp.SetAttributeValue("Name", item.Name);
                xApp.SetAttributeValue("ExePath", item.ExePath);
                data.SavaAsSource();
            }
        }

        public static void RemoveAppItem(AppItem item)
        {
            XDocument data =GlobalVars.SourceData;
            XElement xApp = data.Descendants("App").FirstOrDefault(a => a.Attribute("Id").Value.Equals(item.Id));
            if (xApp != null)
            {
                xApp.Remove();
                data.SavaAsSource();
            }
        }

        #endregion

        #region Service functions

        public static void RunApps(string gId)
        {
            RunApps(GetAppGroup(gId));
        }
        
        public static void RunApps(AppGroup group)
        {
            new Thread(new ThreadStart(() =>
            {
                if (group != null && group.AppItems.Count > 0)
                {
                    foreach (AppItem item in group.AppItems)
                    {
                        try
                        {
                            if (GlobalVars.AppRunIntervalTime > 0)
                            {
                                Thread.Sleep(GlobalVars.AppRunIntervalTime);
                            }

                            //Run app by .NET API
                            Process.Start(item.ExePath);
                        }
                        catch (Exception ex)
                        {
                            if (OnAppRunError != null)
                            {
                                OnAppRunError(new AppItemEventArgs(item, ex));
                            }
                            continue;
                        }
                    }
                }
            })).Start();
        }

        public static void CreateShortcut(AppGroup group)
        {
            string desktopDirectory = string.Empty;
            IWshShortcut shortcut = null;
            WshShellClass shellClass = new WshShellClass();

            desktopDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            shortcut = (IWshShortcut)shellClass.CreateShortcut(Path.Combine(desktopDirectory, string.Format("{0}.lnk", group.Name)));
            shortcut.TargetPath = Application.ExecutablePath;
            shortcut.Description = group.Name;
            shortcut.Arguments = group.Id;
            shortcut.Save();
        }
        #endregion

    }
}
