using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenBrighter
{
    public class BrightnessService
    {
        /// <summary>
        /// Set all screen brightness
        /// </summary>
        /// <param name="delay">delay</param>
        /// <param name="brightness">brightness in %</param>
        public static bool SetBrightness(uint delay, uint brightness)
        {
            try
            {
                WmiService.WmiMonitor.SetBrightness(delay, brightness);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
