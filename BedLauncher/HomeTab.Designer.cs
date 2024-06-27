namespace BedLauncher
{
    partial class HomeTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bannerclipper = new System.Windows.Forms.Panel();
            this.siticoneGradientPanel1 = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.banner = new System.Windows.Forms.PictureBox();
            this.launch = new System.Windows.Forms.PictureBox();
            this.bannerclipper.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.launch)).BeginInit();
            this.SuspendLayout();
            // 
            // bannerclipper
            // 
            this.bannerclipper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.bannerclipper.Controls.Add(this.siticoneGradientPanel1);
            this.bannerclipper.Controls.Add(this.banner);
            this.bannerclipper.Location = new System.Drawing.Point(0, 0);
            this.bannerclipper.Name = "bannerclipper";
            this.bannerclipper.Size = new System.Drawing.Size(1302, 382);
            this.bannerclipper.TabIndex = 2;
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGradientPanel1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.siticoneGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(0, 282);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.ShadowDecoration.Parent = this.siticoneGradientPanel1;
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(1302, 100);
            this.siticoneGradientPanel1.TabIndex = 4;
            this.siticoneGradientPanel1.UseTransparentBackground = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.launch);
            this.panel1.Location = new System.Drawing.Point(0, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 88);
            this.panel1.TabIndex = 3;
            // 
            // banner
            // 
            this.banner.BackgroundImage = global::BedLauncher.Properties.Resources.home_banner;
            this.banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.banner.Location = new System.Drawing.Point(0, 0);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(1302, 464);
            this.banner.TabIndex = 0;
            this.banner.TabStop = false;
            // 
            // launch
            // 
            this.launch.BackgroundImage = global::BedLauncher.Properties.Resources.launch_home;
            this.launch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.launch.Location = new System.Drawing.Point(564, 9);
            this.launch.Name = "launch";
            this.launch.Size = new System.Drawing.Size(471, 72);
            this.launch.TabIndex = 3;
            this.launch.TabStop = false;
            this.launch.Click += new System.EventHandler(this.launch_Click);
            this.launch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.launch_MouseDown);
            this.launch.MouseEnter += new System.EventHandler(this.launch_MouseEnter);
            this.launch.MouseLeave += new System.EventHandler(this.launch_MouseLeave);
            this.launch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.launch_MouseUp);
            // 
            // HomeTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.bannerclipper);
            this.Controls.Add(this.panel1);
            this.Name = "HomeTab";
            this.Size = new System.Drawing.Size(1302, 764);
            this.Load += new System.EventHandler(this.HomeTab_Load);
            this.bannerclipper.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.banner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.launch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox banner;
        private System.Windows.Forms.Panel bannerclipper;
        private System.Windows.Forms.PictureBox launch;
        private System.Windows.Forms.Panel panel1;
        private Siticone.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
    }
}
