using System;
using System.Windows.Forms;
using MonacoTorch.Flashlight;

namespace MonacoTorch
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(OnUnhandledException);

            var mainForm = new MainForm();
            using (IFlashlight flashlight = FlashlightFactory.CreateAppropriateFlashlight())
            {
                mainForm.Flashlight = flashlight;
                Application.Run(mainForm);
            }
        }

        static void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;
            if (ex != null)
            {

            }
        }
    }
}