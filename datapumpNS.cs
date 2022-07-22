using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGiesecke.DllExport;

namespace MTAPIdatapumpNS
{
    public class datapumpNS
    {
        [DllExport("UserIDPasswordChanged", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static long UserIDPasswordChanged(string UserID, string Password)
        {
            /*char temp[200];
            strcpy(temp, UserID);
            strcat(temp, ",");
            strcat(temp, Password);
            MessageBox(NULL, temp, "Data Pump DLL Example", 0);*/
            return -1;
        }

        [DllExport("RemoveTicker", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static long RemoveTicker(string ticker, float BarInterval)
        {
            return 1;
        }

        [DllExport("RequestTicker", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static long RequestTicker(string ticker, string description, string category, double startdate, float BarInterval, string [] ColumnNames)
        {
            return 1;
        }
    }
}
