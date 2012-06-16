using MonacoTorch.Device;

namespace MonacoTorch.Flashlight
{
    static class FlashlightFactory
    {
        public static IFlashlight CreateAppropriateFlashlight()
        {
            if (IsSupportedModel())
            {
                return new MonacoFlashlight();
            }
            else
            {
                return new FakeFlashlight();
            }

        }
        private static bool IsSupportedModel()
        {
            string[] monacoModels = { "LGE-GW820", "LGE-GW825", "LGE-GW825V", "LG-GW825V" };
            string currentModel = Platform.GetOEMDeviceID().ToUpper(System.Globalization.CultureInfo.InvariantCulture);
            bool found = false;

            foreach (string modelName in monacoModels)
            {
                if (currentModel.Equals(modelName))
                {
                    found = true;
                    break;
                }
            }
            return found;
        }
    }
}
