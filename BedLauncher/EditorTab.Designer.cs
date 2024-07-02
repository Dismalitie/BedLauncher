namespace BedLauncher
{
    partial class EditorTab
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
            this.fader = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.launch_strip = new System.Windows.Forms.Panel();
            this.worldContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.overview_tutorial = new System.Windows.Forms.Panel();
            this.tutorial_tutorial = new System.Windows.Forms.Panel();
            this.extensions_tutorial = new System.Windows.Forms.Panel();
            this.overview_tutorial_bar = new System.Windows.Forms.Panel();
            this.overview_tutorial_launch = new System.Windows.Forms.Panel();
            this.overview_tutorial_name = new System.Windows.Forms.Label();
            this.overview_tutorial_banner = new System.Windows.Forms.Panel();
            this.tutorial_tutorial_bar = new System.Windows.Forms.Panel();
            this.tutorial_tutorial_launch = new System.Windows.Forms.Panel();
            this.tutorial_tutorial_name = new System.Windows.Forms.Label();
            this.tutorial_tutorial_banner = new System.Windows.Forms.Panel();
            this.extensions_tutorial_bar = new System.Windows.Forms.Panel();
            this.extensions_tutorial_launch = new System.Windows.Forms.Panel();
            this.extensions_tutorial_name = new System.Windows.Forms.Label();
            this.extensions_tutorial_banner = new System.Windows.Forms.Panel();
            this.world_title = new Siticone.UI.WinForms.SiticonePictureBox();
            this.world_strip = new System.Windows.Forms.PictureBox();
            this.banner = new System.Windows.Forms.PictureBox();
            this.launch = new System.Windows.Forms.PictureBox();
            this.bannerclipper.SuspendLayout();
            this.launch_strip.SuspendLayout();
            this.worldContainer.SuspendLayout();
            this.overview_tutorial.SuspendLayout();
            this.tutorial_tutorial.SuspendLayout();
            this.extensions_tutorial.SuspendLayout();
            this.overview_tutorial_bar.SuspendLayout();
            this.tutorial_tutorial_bar.SuspendLayout();
            this.extensions_tutorial_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.world_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.world_strip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.launch)).BeginInit();
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
            this.bannerclipper.TabIndex = 6;
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
            // launch_strip
            // 
            this.launch_strip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.launch_strip.Controls.Add(this.launch);
            this.launch_strip.Location = new System.Drawing.Point(0, 379);
            this.launch_strip.Name = "launch_strip";
            this.launch_strip.Size = new System.Drawing.Size(1302, 88);
            this.launch_strip.TabIndex = 7;
            // 
            // worldContainer
            // 
            this.worldContainer.Controls.Add(this.overview_tutorial);
            this.worldContainer.Controls.Add(this.tutorial_tutorial);
            this.worldContainer.Controls.Add(this.extensions_tutorial);
            this.worldContainer.Location = new System.Drawing.Point(3, 536);
            this.worldContainer.Name = "worldContainer";
            this.worldContainer.Padding = new System.Windows.Forms.Padding(5);
            this.worldContainer.Size = new System.Drawing.Size(1296, 214);
            this.worldContainer.TabIndex = 10;
            // 
            // overview_tutorial
            // 
            this.overview_tutorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.overview_tutorial.Controls.Add(this.overview_tutorial_bar);
            this.overview_tutorial.Controls.Add(this.overview_tutorial_banner);
            this.overview_tutorial.Location = new System.Drawing.Point(8, 8);
            this.overview_tutorial.Name = "overview_tutorial";
            this.overview_tutorial.Size = new System.Drawing.Size(420, 195);
            this.overview_tutorial.TabIndex = 0;
            // 
            // tutorial_tutorial
            // 
            this.tutorial_tutorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.tutorial_tutorial.Controls.Add(this.tutorial_tutorial_bar);
            this.tutorial_tutorial.Controls.Add(this.tutorial_tutorial_banner);
            this.tutorial_tutorial.Location = new System.Drawing.Point(434, 8);
            this.tutorial_tutorial.Name = "tutorial_tutorial";
            this.tutorial_tutorial.Size = new System.Drawing.Size(420, 195);
            this.tutorial_tutorial.TabIndex = 4;
            // 
            // extensions_tutorial
            // 
            this.extensions_tutorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.extensions_tutorial.Controls.Add(this.extensions_tutorial_bar);
            this.extensions_tutorial.Controls.Add(this.extensions_tutorial_banner);
            this.extensions_tutorial.Location = new System.Drawing.Point(860, 8);
            this.extensions_tutorial.Name = "extensions_tutorial";
            this.extensions_tutorial.Size = new System.Drawing.Size(420, 195);
            this.extensions_tutorial.TabIndex = 5;
            // 
            // overview_tutorial_bar
            // 
            this.overview_tutorial_bar.BackgroundImage = global::BedLauncher.Properties.Resources.bar;
            this.overview_tutorial_bar.Controls.Add(this.overview_tutorial_launch);
            this.overview_tutorial_bar.Controls.Add(this.overview_tutorial_name);
            this.overview_tutorial_bar.Location = new System.Drawing.Point(0, 131);
            this.overview_tutorial_bar.Name = "overview_tutorial_bar";
            this.overview_tutorial_bar.Size = new System.Drawing.Size(420, 64);
            this.overview_tutorial_bar.TabIndex = 2;
            // 
            // overview_tutorial_launch
            // 
            this.overview_tutorial_launch.BackgroundImage = global::BedLauncher.Properties.Resources.open_browser;
            this.overview_tutorial_launch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.overview_tutorial_launch.Location = new System.Drawing.Point(364, 6);
            this.overview_tutorial_launch.Name = "overview_tutorial_launch";
            this.overview_tutorial_launch.Size = new System.Drawing.Size(50, 50);
            this.overview_tutorial_launch.TabIndex = 1;
            this.overview_tutorial_launch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.overview_tutorial_launch_MouseDown);
            this.overview_tutorial_launch.MouseEnter += new System.EventHandler(this.overview_tutorial_launch_MouseEnter);
            this.overview_tutorial_launch.MouseLeave += new System.EventHandler(this.overview_tutorial_launch_MouseLeave);
            this.overview_tutorial_launch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.overview_tutorial_launch_MouseUp);
            // 
            // overview_tutorial_name
            // 
            this.overview_tutorial_name.AutoSize = true;
            this.overview_tutorial_name.BackColor = System.Drawing.Color.Transparent;
            this.overview_tutorial_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overview_tutorial_name.Location = new System.Drawing.Point(11, 21);
            this.overview_tutorial_name.Name = "overview_tutorial_name";
            this.overview_tutorial_name.Size = new System.Drawing.Size(137, 22);
            this.overview_tutorial_name.TabIndex = 0;
            this.overview_tutorial_name.Text = "Editor Overview";
            // 
            // overview_tutorial_banner
            // 
            this.overview_tutorial_banner.BackgroundImage = global::BedLauncher.Properties.Resources.editor_overview_banner;
            this.overview_tutorial_banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.overview_tutorial_banner.Location = new System.Drawing.Point(0, -7);
            this.overview_tutorial_banner.Name = "overview_tutorial_banner";
            this.overview_tutorial_banner.Size = new System.Drawing.Size(420, 192);
            this.overview_tutorial_banner.TabIndex = 3;
            // 
            // tutorial_tutorial_bar
            // 
            this.tutorial_tutorial_bar.BackgroundImage = global::BedLauncher.Properties.Resources.bar;
            this.tutorial_tutorial_bar.Controls.Add(this.tutorial_tutorial_launch);
            this.tutorial_tutorial_bar.Controls.Add(this.tutorial_tutorial_name);
            this.tutorial_tutorial_bar.Location = new System.Drawing.Point(0, 131);
            this.tutorial_tutorial_bar.Name = "tutorial_tutorial_bar";
            this.tutorial_tutorial_bar.Size = new System.Drawing.Size(420, 64);
            this.tutorial_tutorial_bar.TabIndex = 2;
            // 
            // tutorial_tutorial_launch
            // 
            this.tutorial_tutorial_launch.BackgroundImage = global::BedLauncher.Properties.Resources.open_browser;
            this.tutorial_tutorial_launch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tutorial_tutorial_launch.Location = new System.Drawing.Point(364, 6);
            this.tutorial_tutorial_launch.Name = "tutorial_tutorial_launch";
            this.tutorial_tutorial_launch.Size = new System.Drawing.Size(50, 50);
            this.tutorial_tutorial_launch.TabIndex = 1;
            this.tutorial_tutorial_launch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tutorial_tutorial_launch_MouseDown);
            this.tutorial_tutorial_launch.MouseEnter += new System.EventHandler(this.tutorial_tutorial_launch_MouseEnter);
            this.tutorial_tutorial_launch.MouseLeave += new System.EventHandler(this.tutorial_tutorial_launch_MouseLeave);
            this.tutorial_tutorial_launch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tutorial_tutorial_launch_MouseUp);
            // 
            // tutorial_tutorial_name
            // 
            this.tutorial_tutorial_name.AutoSize = true;
            this.tutorial_tutorial_name.BackColor = System.Drawing.Color.Transparent;
            this.tutorial_tutorial_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorial_tutorial_name.Location = new System.Drawing.Point(11, 21);
            this.tutorial_tutorial_name.Name = "tutorial_tutorial_name";
            this.tutorial_tutorial_name.Size = new System.Drawing.Size(123, 22);
            this.tutorial_tutorial_name.TabIndex = 0;
            this.tutorial_tutorial_name.Text = "Editor Tutorial";
            // 
            // tutorial_tutorial_banner
            // 
            this.tutorial_tutorial_banner.BackgroundImage = global::BedLauncher.Properties.Resources.editor_tutorial_banner;
            this.tutorial_tutorial_banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tutorial_tutorial_banner.Location = new System.Drawing.Point(0, -4);
            this.tutorial_tutorial_banner.Name = "tutorial_tutorial_banner";
            this.tutorial_tutorial_banner.Size = new System.Drawing.Size(420, 192);
            this.tutorial_tutorial_banner.TabIndex = 3;
            // 
            // extensions_tutorial_bar
            // 
            this.extensions_tutorial_bar.BackgroundImage = global::BedLauncher.Properties.Resources.bar;
            this.extensions_tutorial_bar.Controls.Add(this.extensions_tutorial_launch);
            this.extensions_tutorial_bar.Controls.Add(this.extensions_tutorial_name);
            this.extensions_tutorial_bar.Location = new System.Drawing.Point(0, 131);
            this.extensions_tutorial_bar.Name = "extensions_tutorial_bar";
            this.extensions_tutorial_bar.Size = new System.Drawing.Size(420, 64);
            this.extensions_tutorial_bar.TabIndex = 2;
            // 
            // extensions_tutorial_launch
            // 
            this.extensions_tutorial_launch.BackgroundImage = global::BedLauncher.Properties.Resources.open_browser;
            this.extensions_tutorial_launch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.extensions_tutorial_launch.Location = new System.Drawing.Point(364, 6);
            this.extensions_tutorial_launch.Name = "extensions_tutorial_launch";
            this.extensions_tutorial_launch.Size = new System.Drawing.Size(50, 50);
            this.extensions_tutorial_launch.TabIndex = 1;
            this.extensions_tutorial_launch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.extensions_tutorial_launch_MouseDown);
            this.extensions_tutorial_launch.MouseEnter += new System.EventHandler(this.extensions_tutorial_launch_MouseEnter);
            this.extensions_tutorial_launch.MouseLeave += new System.EventHandler(this.extensions_tutorial_launch_MouseLeave);
            this.extensions_tutorial_launch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.extensions_tutorial_launch_MouseUp);
            // 
            // extensions_tutorial_name
            // 
            this.extensions_tutorial_name.AutoSize = true;
            this.extensions_tutorial_name.BackColor = System.Drawing.Color.Transparent;
            this.extensions_tutorial_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extensions_tutorial_name.Location = new System.Drawing.Point(11, 21);
            this.extensions_tutorial_name.Name = "extensions_tutorial_name";
            this.extensions_tutorial_name.Size = new System.Drawing.Size(150, 22);
            this.extensions_tutorial_name.TabIndex = 0;
            this.extensions_tutorial_name.Text = "Editor Extensions";
            // 
            // extensions_tutorial_banner
            // 
            this.extensions_tutorial_banner.BackgroundImage = global::BedLauncher.Properties.Resources.editor_extensions_banner;
            this.extensions_tutorial_banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.extensions_tutorial_banner.Location = new System.Drawing.Point(0, -4);
            this.extensions_tutorial_banner.Name = "extensions_tutorial_banner";
            this.extensions_tutorial_banner.Size = new System.Drawing.Size(420, 310);
            this.extensions_tutorial_banner.TabIndex = 3;
            // 
            // world_title
            // 
            this.world_title.BackgroundImage = global::BedLauncher.Properties.Resources.useful_links;
            this.world_title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.world_title.Location = new System.Drawing.Point(13, 473);
            this.world_title.Name = "world_title";
            this.world_title.ShadowDecoration.Parent = this.world_title;
            this.world_title.Size = new System.Drawing.Size(409, 45);
            this.world_title.TabIndex = 9;
            this.world_title.TabStop = false;
            // 
            // world_strip
            // 
            this.world_strip.BackgroundImage = global::BedLauncher.Properties.Resources.secondary_bar;
            this.world_strip.Location = new System.Drawing.Point(0, 466);
            this.world_strip.Name = "world_strip";
            this.world_strip.Size = new System.Drawing.Size(1302, 64);
            this.world_strip.TabIndex = 8;
            this.world_strip.TabStop = false;
            // 
            // banner
            // 
            this.banner.BackgroundImage = global::BedLauncher.Properties.Resources.editor_banner;
            this.banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.banner.Location = new System.Drawing.Point(0, 0);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(1302, 464);
            this.banner.TabIndex = 0;
            this.banner.TabStop = false;
            // 
            // launch
            // 
            this.launch.BackgroundImage = global::BedLauncher.Properties.Resources.launch_editor;
            this.launch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.launch.Location = new System.Drawing.Point(433, 9);
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
            // EditorTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.worldContainer);
            this.Controls.Add(this.world_title);
            this.Controls.Add(this.world_strip);
            this.Controls.Add(this.bannerclipper);
            this.Controls.Add(this.launch_strip);
            this.Name = "EditorTab";
            this.Size = new System.Drawing.Size(1302, 764);
            this.Load += new System.EventHandler(this.EditorTab_Load);
            this.bannerclipper.ResumeLayout(false);
            this.launch_strip.ResumeLayout(false);
            this.worldContainer.ResumeLayout(false);
            this.overview_tutorial.ResumeLayout(false);
            this.tutorial_tutorial.ResumeLayout(false);
            this.extensions_tutorial.ResumeLayout(false);
            this.overview_tutorial_bar.ResumeLayout(false);
            this.overview_tutorial_bar.PerformLayout();
            this.tutorial_tutorial_bar.ResumeLayout(false);
            this.tutorial_tutorial_bar.PerformLayout();
            this.extensions_tutorial_bar.ResumeLayout(false);
            this.extensions_tutorial_bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.world_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.world_strip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.launch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bannerclipper;
        private Siticone.UI.WinForms.SiticoneGradientPanel fader;
        private System.Windows.Forms.PictureBox banner;
        private System.Windows.Forms.Panel launch_strip;
        private System.Windows.Forms.PictureBox launch;
        private Siticone.UI.WinForms.SiticonePictureBox world_title;
        private System.Windows.Forms.PictureBox world_strip;
        private System.Windows.Forms.FlowLayoutPanel worldContainer;
        private System.Windows.Forms.Panel overview_tutorial;
        private System.Windows.Forms.Panel overview_tutorial_bar;
        private System.Windows.Forms.Panel overview_tutorial_launch;
        private System.Windows.Forms.Label overview_tutorial_name;
        private System.Windows.Forms.Panel overview_tutorial_banner;
        private System.Windows.Forms.Panel tutorial_tutorial;
        private System.Windows.Forms.Panel tutorial_tutorial_bar;
        private System.Windows.Forms.Panel tutorial_tutorial_launch;
        private System.Windows.Forms.Label tutorial_tutorial_name;
        private System.Windows.Forms.Panel tutorial_tutorial_banner;
        private System.Windows.Forms.Panel extensions_tutorial;
        private System.Windows.Forms.Panel extensions_tutorial_bar;
        private System.Windows.Forms.Panel extensions_tutorial_launch;
        private System.Windows.Forms.Label extensions_tutorial_name;
        private System.Windows.Forms.Panel extensions_tutorial_banner;
    }
}
