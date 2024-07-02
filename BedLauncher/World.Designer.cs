namespace BedLauncher
{
    partial class World
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
            this.titlebar = new System.Windows.Forms.Panel();
            this.play = new System.Windows.Forms.Panel();
            this.worldname = new System.Windows.Forms.Label();
            this.worldbanner = new System.Windows.Forms.Panel();
            this.titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlebar
            // 
            this.titlebar.BackgroundImage = global::BedLauncher.Properties.Resources.bar;
            this.titlebar.Controls.Add(this.play);
            this.titlebar.Controls.Add(this.worldname);
            this.titlebar.Location = new System.Drawing.Point(0, 131);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(420, 64);
            this.titlebar.TabIndex = 0;
            // 
            // play
            // 
            this.play.BackgroundImage = global::BedLauncher.Properties.Resources.world_play;
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.play.Location = new System.Drawing.Point(364, 6);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(50, 50);
            this.play.TabIndex = 1;
            this.play.MouseDown += new System.Windows.Forms.MouseEventHandler(this.play_MouseDown);
            this.play.MouseEnter += new System.EventHandler(this.play_MouseEnter);
            this.play.MouseLeave += new System.EventHandler(this.play_MouseLeave);
            this.play.MouseUp += new System.Windows.Forms.MouseEventHandler(this.play_MouseUp);
            // 
            // worldname
            // 
            this.worldname.AutoSize = true;
            this.worldname.BackColor = System.Drawing.Color.Transparent;
            this.worldname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worldname.Location = new System.Drawing.Point(11, 21);
            this.worldname.Name = "worldname";
            this.worldname.Size = new System.Drawing.Size(243, 22);
            this.worldname.TabIndex = 0;
            this.worldname.Text = "%WORLD_NAME_TOKEN%";
            // 
            // worldbanner
            // 
            this.worldbanner.BackgroundImage = global::BedLauncher.Properties.Resources.generic_banner;
            this.worldbanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.worldbanner.Location = new System.Drawing.Point(0, -33);
            this.worldbanner.Name = "worldbanner";
            this.worldbanner.Size = new System.Drawing.Size(420, 192);
            this.worldbanner.TabIndex = 1;
            // 
            // World
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.titlebar);
            this.Controls.Add(this.worldbanner);
            this.Name = "World";
            this.Size = new System.Drawing.Size(420, 195);
            this.Load += new System.EventHandler(this.World_Load);
            this.titlebar.ResumeLayout(false);
            this.titlebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlebar;
        private System.Windows.Forms.Panel worldbanner;
        private System.Windows.Forms.Panel play;
        public System.Windows.Forms.Label worldname;
    }
}
