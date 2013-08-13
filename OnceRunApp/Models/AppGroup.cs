using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OnceRunApp.Base;

namespace OnceRunApp.Models
{
    public class AppGroup : ModelBase
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

        private string description;

        public string Description
        {
            get { return description; }
            set { SetField(ref description, value, "Description"); }
        }
    
        public List<AppItem> AppItems { get; set; }

        public override bool Validate()
        {
            if (string.IsNullOrEmpty(this.name))
            {
                throw new MyAlertException("Group name is empty!");
            }

            return base.Validate();
        }
    }
}
