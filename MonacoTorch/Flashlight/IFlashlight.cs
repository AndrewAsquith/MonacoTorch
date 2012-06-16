using System;

namespace MonacoTorch.Flashlight
{
    public interface IFlashlight : IDisposable
    {
        bool IsRunning { get; }

        void TurnOn();

        void TurnOff();
    }
}
