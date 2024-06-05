using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ReteiconAutomationProject.Params
{
    public class DefaultVariables
    {
        public string Results
        {
            get

            {

                return System.IO.Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory + "../../../").FullName + @"\Results\Reports"
                  + DateTime.Now.ToString("yyyMMdd hhmm");
            }

        }
        

        public string Log { get
            {
                return Results + "\\.log.txt";
            }
        
        
        }
        

        
    }
}        

