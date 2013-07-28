using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnceRunApp.Base
{
    public sealed class HandlerHub
    {
        private HandlerHub() { }

        public static void Invoke(IHandler handler)
        {
            if (handler != null)
            {
                handler.Execute();
            }
        }
    }
}
