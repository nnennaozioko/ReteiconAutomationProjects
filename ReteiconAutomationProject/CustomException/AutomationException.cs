using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReteiconAutomationProject.CustomException
{
    public class AutomationException : Exception // all exceptions are defaults
    {
        // FileNotFoundException
        public AutomationException(string message) : base($"{message}")
        {

        }

        public AutomationException(ErrorItems items) : base($"{items}")
        {

        }


        public AutomationException(ErrorItems items, string message) : base($"{items}: {message}")
        {

        }









    }
}
