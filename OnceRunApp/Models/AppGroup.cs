using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnceRunApp.Models
{
    public class AppGroup : NotificationBase
    {
        public AppGroup()
        {
            this.Id = Guid.NewGuid().ToString().ToUpper();
        }

        public AppGroup(string name)
        {
            this.Id = Guid.NewGuid().ToString().ToUpper();
            this.Name = name;
            this.AppItems = new List<AppItem>() { new AppItem() };
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { SetField(ref id, value, "Id"); }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { SetField(ref name, value, "Name"); }
        }
    
        public List<AppItem> AppItems { get; set; }
    }
}
