namespace MonacoTorch
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.OffButton = new MonacoTorch.Controls.ImageButton();
            this.AboutButton = new MonacoTorch.Controls.ImageButton();
            this.SuspendLayout();
            // 
            // OffButton
            // 
            this.OffButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OffButton.Location = new System.Drawing.Point(0, 0);
            this.OffButton.Name = "OffButton";
            this.OffButton.NormalImage = ((System.Drawing.Bitmap)(resources.GetObject("OffButton.NormalImage")));
            this.OffButton.PressedImage = ((System.Drawing.Bitmap)(resources.GetObject("OffButton.PressedImage")));
            this.OffButton.Size = new System.Drawing.Size(240, 240);
            this.OffButton.TabIndex = 0;
            this.OffButton.Click += new System.EventHandler(this.OffButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AboutButton.Location = new System.Drawing.Point(0, 245);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.NormalImage = ((System.Drawing.Bitmap)(resources.GetObject("AboutButton.NormalImage")));
            this.AboutButton.PressedImage = ((System.Drawing.Bitmap)(resources.GetObject("AboutButton.PressedImage")));
            this.AboutButton.Size = new System.Drawing.Size(75, 75);
            this.AboutButton.TabIndex = 2;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.OffButton);
            this.Controls.Add(this.AboutButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MonacoTorch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closed += new System.EventHandler(this.MainForm_Closed);
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private MonacoTorch.Controls.ImageButton AboutButton;
        private MonacoTorch.Controls.ImageButton OffButton;
    }
}

