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
            this.Id = Guid.NewGuid().ToString();
        }

        public AppGroup(string name)
            : base()
        {
            this.Name = name;
            this.AppItems = new List<AppItem>(){ new AppItem() };
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
    
        public IEnumerable<AppItem> AppItems { get; set; }
    }
}
