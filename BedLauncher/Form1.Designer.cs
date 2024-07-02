namespace BedLauncher
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dragger = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.tabcontainer = new System.Windows.Forms.Panel();
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.min = new System.Windows.Forms.PictureBox();
            this.cls = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.PictureBox();
            this.topbar = new System.Windows.Forms.PictureBox();
            this.settings = new System.Windows.Forms.PictureBox();
            this.editor = new System.Windows.Forms.PictureBox();
            this.preview = new System.Windows.Forms.PictureBox();
            this.home = new System.Windows.Forms.PictureBox();
            this.not_found = new System.Windows.Forms.PictureBox();
            this.tabcontainer.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.not_found)).BeginInit();
            this.SuspendLayout();
            // 
            // dragger
            // 
            this.dragger.TargetControl = this.topbar;
            // 
            // tabcontainer
            // 
            this.tabcontainer.Controls.Add(this.not_found);
            this.tabcontainer.Location = new System.Drawing.Point(74, 59);
            this.tabcontainer.Name = "tabcontainer";
            this.tabcontainer.Size = new System.Drawing.Size(1293, 764);
            this.tabcontainer.TabIndex = 5;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.siticonePanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(108)))), ((int)(((byte)(109)))));
            this.siticonePanel1.Controls.Add(this.settings);
            this.siticonePanel1.Controls.Add(this.editor);
            this.siticonePanel1.Controls.Add(this.preview);
            this.siticonePanel1.Controls.Add(this.home);
            this.siticonePanel1.Location = new System.Drawing.Point(-1, 60);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(75, 771);
            this.siticonePanel1.TabIndex = 8;
            // 
            // min
            // 
            this.min.BackgroundImage = global::BedLauncher.Properties.Resources.min;
            this.min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.min.Location = new System.Drawing.Point(1283, 12);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(32, 32);
            this.min.TabIndex = 3;
            this.min.TabStop = false;
            this.min.Click += new System.EventHandler(this.min_Click);
            this.min.MouseDown += new System.Windows.Forms.MouseEventHandler(this.min_MouseDown);
            this.min.MouseEnter += new System.EventHandler(this.min_MouseEnter);
            this.min.MouseLeave += new System.EventHandler(this.min_MouseLeave);
            this.min.MouseUp += new System.Windows.Forms.MouseEventHandler(this.min_MouseUp);
            // 
            // cls
            // 
            this.cls.BackgroundImage = global::BedLauncher.Properties.Resources.x;
            this.cls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cls.Location = new System.Drawing.Point(1321, 12);
            this.cls.Name = "cls";
            this.cls.Size = new System.Drawing.Size(32, 32);
            this.cls.TabIndex = 2;
            this.cls.TabStop = false;
            this.cls.Click += new System.EventHandler(this.cls_Click);
            this.cls.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cls_MouseDown);
            this.cls.MouseEnter += new System.EventHandler(this.cls_MouseEnter);
            this.cls.MouseLeave += new System.EventHandler(this.cls_MouseLeave);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.BackgroundImage = global::BedLauncher.Properties.Resources.title_large;
            this.title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.title.Location = new System.Drawing.Point(12, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(295, 38);
            this.title.TabIndex = 1;
            this.title.TabStop = false;
            this.title.MouseEnter += new System.EventHandler(this.title_MouseEnter);
            this.title.MouseLeave += new System.EventHandler(this.title_MouseLeave);
            // 
            // topbar
            // 
            this.topbar.BackgroundImage = global::BedLauncher.Properties.Resources.bar;
            this.topbar.Location = new System.Drawing.Point(-1, -2);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(1368, 64);
            this.topbar.TabIndex = 0;
            this.topbar.TabStop = false;
            // 
            // settings
            // 
            this.settings.BackgroundImage = global::BedLauncher.Properties.Resources.settings;
            this.settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settings.Location = new System.Drawing.Point(5, 687);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(64, 64);
            this.settings.TabIndex = 8;
            this.settings.TabStop = false;
            this.settings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.settings_MouseDown);
            this.settings.MouseEnter += new System.EventHandler(this.settings_MouseEnter);
            this.settings.MouseLeave += new System.EventHandler(this.settings_MouseLeave);
            // 
            // editor
            // 
            this.editor.BackgroundImage = global::BedLauncher.Properties.Resources.editor;
            this.editor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editor.Location = new System.Drawing.Point(5, 152);
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(64, 64);
            this.editor.TabIndex = 7;
            this.editor.TabStop = false;
            this.editor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.editor_MouseDown);
            this.editor.MouseEnter += new System.EventHandler(this.editor_MouseEnter);
            this.editor.MouseLeave += new System.EventHandler(this.editor_MouseLeave);
            // 
            // preview
            // 
            this.preview.BackgroundImage = global::BedLauncher.Properties.Resources.preview;
            this.preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.preview.Location = new System.Drawing.Point(5, 82);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(64, 64);
            this.preview.TabIndex = 6;
            this.preview.TabStop = false;
            this.preview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.preview_MouseDown);
            this.preview.MouseEnter += new System.EventHandler(this.preview_MouseEnter);
            this.preview.MouseLeave += new System.EventHandler(this.preview_MouseLeave);
            // 
            // home
            // 
            this.home.BackgroundImage = global::BedLauncher.Properties.Resources.home_pressed;
            this.home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.home.Location = new System.Drawing.Point(5, 12);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(64, 64);
            this.home.TabIndex = 5;
            this.home.TabStop = false;
            this.home.MouseDown += new System.Windows.Forms.MouseEventHandler(this.home_MouseDown);
            this.home.MouseEnter += new System.EventHandler(this.home_MouseEnter);
            this.home.MouseLeave += new System.EventHandler(this.home_MouseLeave);
            // 
            // not_found
            // 
            this.not_found.BackgroundImage = global::BedLauncher.Properties.Resources.not_found;
            this.not_found.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.not_found.Location = new System.Drawing.Point(372, 309);
            this.not_found.Name = "not_found";
            this.not_found.Size = new System.Drawing.Size(460, 99);
            this.not_found.TabIndex = 7;
            this.not_found.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1365, 823);
            this.Controls.Add(this.min);
            this.Controls.Add(this.cls);
            this.Controls.Add(this.title);
            this.Controls.Add(this.topbar);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.tabcontainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BedLauncher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabcontainer.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.not_found)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox topbar;
        private System.Windows.Forms.PictureBox title;
        private System.Windows.Forms.PictureBox cls;
        private System.Windows.Forms.PictureBox min;
        private Siticone.UI.WinForms.SiticoneDragControl dragger;
        private System.Windows.Forms.PictureBox home;
        private System.Windows.Forms.Panel tabcontainer;
        private System.Windows.Forms.PictureBox preview;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.PictureBox not_found;
        private System.Windows.Forms.PictureBox editor;
        private System.Windows.Forms.PictureBox settings;
    }
}

