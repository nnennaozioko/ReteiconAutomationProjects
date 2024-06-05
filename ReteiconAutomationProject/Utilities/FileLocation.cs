using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReteiconAutomationProject.Utilities
{
    public class FileLocation 
    {

        public string GetFolderLocation(string folder)
        {
            return Directory.GetParent(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location).ToString(), @"..\..\")) + @"\" + folder + @"\";
        }
        
    }
}
