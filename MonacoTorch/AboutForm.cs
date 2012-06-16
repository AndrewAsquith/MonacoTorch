using System;

using System.Windows.Forms;

namespace MonacoTorch
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        public string Version { get; set; }
        public string DeviceID { get; set; }
        

        private void AboutForm_Load(object sender, EventArgs e)
        {
            VersionLabel.Text = "Version: " + Version;
            DeviceIDLabel.Text = "Running on: " + DeviceID;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}