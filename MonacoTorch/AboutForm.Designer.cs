namespace MonacoTorch
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.AboutTitle = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.DeviceIDLabel = new System.Windows.Forms.Label();
            this.OkButton = new MonacoTorch.Controls.ImageButton();
            this.SuspendLayout();
            // 
            // AboutTitle
            // 
            this.AboutTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AboutTitle.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular);
            this.AboutTitle.ForeColor = System.Drawing.Color.White;
            this.AboutTitle.Location = new System.Drawing.Point(10, 0);
            this.AboutTitle.Name = "AboutTitle";
            this.AboutTitle.Size = new System.Drawing.Size(220, 100);
            this.AboutTitle.Text = "Monaco Torch";
            this.AboutTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VersionLabel
            // 
            this.VersionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VersionLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.VersionLabel.ForeColor = System.Drawing.Color.White;
            this.VersionLabel.Location = new System.Drawing.Point(10, 135);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(220, 20);
            this.VersionLabel.Text = "Version: ";
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DeviceIDLabel
            // 
            this.DeviceIDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeviceIDLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.DeviceIDLabel.ForeColor = System.Drawing.Color.White;
            this.DeviceIDLabel.Location = new System.Drawing.Point(10, 160);
            this.DeviceIDLabel.Name = "DeviceIDLabel";
            this.DeviceIDLabel.Size = new System.Drawing.Size(220, 50);
            this.DeviceIDLabel.Text = "Running on: ";
            this.DeviceIDLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(155, 230);
            this.OkButton.Name = "OkButton";
            this.OkButton.NormalImage = ((System.Drawing.Bitmap)(resources.GetObject("OkButton.NormalImage")));
            this.OkButton.PressedImage = ((System.Drawing.Bitmap)(resources.GetObject("OkButton.PressedImage")));
            this.OkButton.Size = new System.Drawing.Size(75, 75);
            this.OkButton.TabIndex = 0;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.DeviceIDLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.AboutTitle);
            this.Controls.Add(this.OkButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Text = "About";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MonacoTorch.Controls.ImageButton OkButton;
        private System.Windows.Forms.Label AboutTitle;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label DeviceIDLabel;
    }
}