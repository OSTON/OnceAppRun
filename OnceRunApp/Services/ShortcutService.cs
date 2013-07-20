using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using IWshRuntimeLibrary;
using Shell32;
using System.IO;
using System.Windows.Forms;

using OnceRunApp.Models;

namespace OnceRunApp.Services
{
    public class ShortcutService
    {
        public static void CreateShortcut(AppGroup group)
        {
            string desktopDirectory = string.Empty;
            IWshShortcut shortcut = null;
            WshShellClass shellClass = new WshShellClass();
            
            desktopDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            shortcut =(IWshShortcut)shellClass.CreateShortcut(Path.Combine(desktopDirectory,string.Format("{0}.lnk",group.Name)));
            shortcut.TargetPath = Application.ExecutablePath;
            shortcut.Description = group.Name;
            shortcut.Arguments = group.Id;
            shortcut.Save();
        }


    }
}
