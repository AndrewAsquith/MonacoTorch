using System;
using System.Text;

namespace MonacoTorch.Device
{
    public static class Platform
    {
        private const uint SPI_GETOEMINFO = 258;

        public static string GetOEMDeviceID()
        {
            string result;
            try
            {
                result = GetSystemParameter(SPI_GETOEMINFO);
            }
            catch (ApplicationException ex)
            {
                //log failed attempt?
                result = "Unknown Device";
            }
            return result;
        }

        private static string GetSystemParameter(uint sysparam)
        {
            StringBuilder sb = new StringBuilder(128);
            if (NativeMethods.SystemParametersInfo(sysparam, (uint)sb.Capacity, sb, 0) == 0)
            {
                throw new ApplicationException("Failed to get system parameter");
            }
            return sb.ToString();
        }

        public static void ResetIdleTimer()
        {
            NativeMethods.SystemIdleTimerReset();
        }
    }
}
