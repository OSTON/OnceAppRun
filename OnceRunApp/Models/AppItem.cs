using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnceRunApp.Models
{
    public class AppItem : NotificationBase
    {
        public AppItem()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { SetField(ref id,value,"Id"); }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { SetField(ref name,value,"Name"); }
        }

        private string exePath;

        public string ExePath
        {
            get { return exePath; }
            set { SetField(ref exePath,value,"ExePath"); }
        }

        public AppItemAction Action { get; set; }
    }
}
