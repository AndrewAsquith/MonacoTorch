using System;
using System.Reflection;
using System.Windows.Forms;
using MonacoTorch.Flashlight;
using MonacoTorch.Device;

namespace MonacoTorch
{
    public partial class MainForm : Form
    {

        public IFlashlight Flashlight { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Closed(object sender, EventArgs e)
        {
            Flashlight.TurnOff();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            Flashlight.TurnOn();
        }

        private void OffButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.Owner = this;
            aboutForm.Version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            aboutForm.DeviceID = Platform.GetOEMDeviceID();
            aboutForm.Show();
        }
    }
}