using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace OnceRunApp.Base
{
    public static  class ExtensionMethods
    {

        #region XDocument

        /// <summary>
        /// Save xml source as application data file
        /// </summary>
        /// <param name="source"></param>
        public static void SavaAsSource(this XDocument source)
        {
            source.Save(GlobalVars.DataFile);
        }        
        #endregion

    }
}
