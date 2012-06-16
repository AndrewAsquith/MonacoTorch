using System.Runtime.InteropServices;

namespace MonacoTorch.Device
{
    internal static class MonacoCameraPlatform
    {

        [DllImport("CameraPlatform.dll")]
        public static extern int White_LED_SET_High(uint data);

        [DllImport("CameraPlatform.dll")]
        public static extern int White_LED_SET_Low(uint data);

        [DllImport("CameraPlatform.dll")]
        public static extern int CameraSensorGPIO_ConfigParallelCamera(uint data);

        [DllImport("CameraPlatform.dll")]
        public static extern int CameraSensorGPIO_ConfigDefault(uint data);

    }
}
