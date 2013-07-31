using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OnceRunApp.Base;

namespace OnceRunApp.Handlers
{
    public class AboutMeHandler : IHandler
    {
        public AboutMeHandler(RunForm form)
        {
            this.Form = form;
        }

        public RunForm Form { get; set; }

        public void Execute()
        {
            AboutBox box = new AboutBox();
            box.ShowDialog(this.Form);
        }
    }
}
