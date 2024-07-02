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
            this.components = new System.ComponentModel.Container();
            this.bannerclipper = new System.Windows.Forms.Panel();
            this.fader = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.banner = new System.Windows.Forms.PictureBox();
            this.launch_holder = new System.Windows.Forms.Panel();
            this.launch = new System.Windows.Forms.PictureBox();
            this.worldContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.world_title = new Siticone.UI.WinForms.SiticonePictureBox();
            this.world_strip = new System.Windows.Forms.PictureBox();
            this.refresher = new System.Windows.Forms.Timer(this.components);
            this.bannerclipper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
            this.launch_holder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.launch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.world_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.world_strip)).BeginInit();
            this.SuspendLayout();
            // 
            // bannerclipper
            // 
            this.bannerclipper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.bannerclipper.Controls.Add(this.fader);
            this.bannerclipper.Controls.Add(this.banner);
            this.bannerclipper.Location = new System.Drawing.Point(0, 0);
            this.bannerclipper.Name = "bannerclipper";
            this.bannerclipper.Size = new System.Drawing.Size(1302, 382);
            this.bannerclipper.TabIndex = 2;
            // 
            // fader
            // 
            this.fader.BackColor = System.Drawing.Color.Transparent;
            this.fader.FillColor = System.Drawing.Color.Transparent;
            this.fader.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.fader.Location = new System.Drawing.Point(0, 282);
            this.fader.Name = "fader";
            this.fader.ShadowDecoration.Parent = this.fader;
            this.fader.Size = new System.Drawing.Size(1302, 100);
            this.fader.TabIndex = 4;
            this.fader.UseTransparentBackground = true;
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
            // launch_holder
            // 
            this.launch_holder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.launch_holder.Controls.Add(this.launch);
            this.launch_holder.Location = new System.Drawing.Point(0, 379);
            this.launch_holder.Name = "launch_holder";
            this.launch_holder.Size = new System.Drawing.Size(1302, 88);
            this.launch_holder.TabIndex = 3;
            // 
            // launch
            // 
            this.launch.BackgroundImage = global::BedLauncher.Properties.Resources.launch_home;
            this.launch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.launch.Location = new System.Drawing.Point(453, 9);
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
            // worldContainer
            // 
            this.worldContainer.Location = new System.Drawing.Point(3, 536);
            this.worldContainer.Name = "worldContainer";
            this.worldContainer.Padding = new System.Windows.Forms.Padding(5);
            this.worldContainer.Size = new System.Drawing.Size(1296, 214);
            this.worldContainer.TabIndex = 9;
            // 
            // world_title
            // 
            this.world_title.BackgroundImage = global::BedLauncher.Properties.Resources.worlds;
            this.world_title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.world_title.Location = new System.Drawing.Point(13, 473);
            this.world_title.Name = "world_title";
            this.world_title.ShadowDecoration.Parent = this.world_title;
            this.world_title.Size = new System.Drawing.Size(200, 45);
            this.world_title.TabIndex = 6;
            this.world_title.TabStop = false;
            // 
            // world_strip
            // 
            this.world_strip.BackgroundImage = global::BedLauncher.Properties.Resources.secondary_bar;
            this.world_strip.Location = new System.Drawing.Point(0, 466);
            this.world_strip.Name = "world_strip";
            this.world_strip.Size = new System.Drawing.Size(1302, 64);
            this.world_strip.TabIndex = 4;
            this.world_strip.TabStop = false;
            // 
            // refresher
            // 
            this.refresher.Enabled = true;
            this.refresher.Interval = 10;
            this.refresher.Tick += new System.EventHandler(this.refresher_Tick);
            // 
            // HomeTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.worldContainer);
            this.Controls.Add(this.world_title);
            this.Controls.Add(this.world_strip);
            this.Controls.Add(this.bannerclipper);
            this.Controls.Add(this.launch_holder);
            this.Name = "HomeTab";
            this.Size = new System.Drawing.Size(1302, 764);
            this.Load += new System.EventHandler(this.HomeTab_Load);
            this.bannerclipper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.banner)).EndInit();
            this.launch_holder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.launch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.world_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.world_strip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox banner;
        private System.Windows.Forms.Panel bannerclipper;
        private System.Windows.Forms.PictureBox launch;
        private System.Windows.Forms.Panel launch_holder;
        private Siticone.UI.WinForms.SiticoneGradientPanel fader;
        private System.Windows.Forms.PictureBox world_strip;
        private Siticone.UI.WinForms.SiticonePictureBox world_title;
        private System.Windows.Forms.FlowLayoutPanel worldContainer;
        private System.Windows.Forms.Timer refresher;
    }
}
