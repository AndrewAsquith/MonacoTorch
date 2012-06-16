
namespace MonacoTorch.Flashlight
{
    class FakeFlashlight : IFlashlight
    {

        private bool isRunning;
        public bool IsRunning
        {
            get { return isRunning; }
        }

        public void TurnOn()
        {
            isRunning = true;
        }

        public void TurnOff()
        {
            isRunning = false;
        }

        public void Dispose()
        {
        }

    }
}
