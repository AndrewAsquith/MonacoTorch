using System;
using MonacoTorch.Device;

namespace MonacoTorch.Flashlight
{
    public class MonacoFlashlight : IFlashlight
    {
        public MonacoFlashlight()
        {
        }

        private bool isInitialized = false;
        private bool isRunning = false;

        public bool IsRunning
        {
            get { return isRunning; }
        }

        public void TurnOn()
        {
            if (!isRunning)
            {
                try
                {
                    if (!isInitialized)
                    {
                        Initialize();
                    }
                    MonacoCameraPlatform.White_LED_SET_High(1);
                    isRunning = true;
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Failed to turn on: " + ex.Message);
                }
            }
        }

        public void TurnOff()
        {
            if (isInitialized && isRunning)
            {
                try
                {
                    MonacoCameraPlatform.White_LED_SET_Low(1);
                    isRunning = false;
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Failed to turn off: " + ex.Message, ex);
                }
            }
        }

        private void Initialize()
        {
            if (!isInitialized)
            {
                try
                {
                    MonacoCameraPlatform.CameraSensorGPIO_ConfigParallelCamera(1);
                    isInitialized = true;
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Falied to initialize: " + ex.Message, ex);
                }
            }
        }

        private void DeInitialize()
        {
            if (isInitialized)
            {
                try
                {
                    if (isRunning)
                    {
                        TurnOff();
                    }

                    MonacoCameraPlatform.CameraSensorGPIO_ConfigDefault(0);
                    isInitialized = false;
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Falied to deinitialize: " + ex.Message, ex);
                }
            }
        }


        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    try
                    {
                        DeInitialize();
                    }
                    catch (Exception ex)
                    {
                        //cant do much at this point so we dine on ex!
                    }
                    finally
                    {
                        disposed = true;
                    }
                }
            }
        }
    }
}
