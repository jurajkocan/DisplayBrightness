using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ScreenBrighter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
#if DEBUG
            SetScreenBrightService service = new SetScreenBrightService(new string[] { });
            service.onDebug();
            Console.WriteLine("Service is running in debugg mode");
            while (true) {
            }
#else
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new SetScreenBright(args)
            };
            ServiceBase.Run(ServicesToRun);
#endif
        }
    }
}
