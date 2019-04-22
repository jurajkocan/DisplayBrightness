using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WmiService
{
    public struct WmiMonitor
    {       
        public static void SetBrightness(UInt32 timeout, uint brightness)
        {
            ManagementClass mc = new ManagementClass(string.Format(@"\\{0}\root\wmi:WmiMonitorBrightnessMethods", Environment.MachineName));
            var instances = mc.GetInstances();
            foreach (ManagementObject mo in instances)
            {
                ManagementBaseObject inParams = mo.GetMethodParameters("wmisetbrightness");
                inParams["timeout"] = timeout;
                inParams["brightness"] = brightness;
                mo.InvokeMethod("wmisetbrightness", inParams, null);
            }           
        }
    }
}
