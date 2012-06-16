using System.Runtime.InteropServices;
using System.Text;

namespace MonacoTorch.Device
{
    internal static class NativeMethods
    {

        [DllImport("Coredll.dll")]
        public static extern void SystemIdleTimerReset();

        [DllImport("Coredll.dll", CharSet = CharSet.Unicode)]
        public static extern int SystemParametersInfo(uint uiAction, uint uiParam, StringBuilder pvParam, uint fWinIni);

    }
}
