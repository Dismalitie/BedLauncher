namespace BedLauncher
{
    partial class EditorNotFound
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
            this.not_found = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.not_found)).BeginInit();
            this.SuspendLayout();
            // 
            // not_found
            // 
            this.not_found.BackgroundImage = global::BedLauncher.Properties.Resources.editor_not_found;
            this.not_found.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.not_found.Location = new System.Drawing.Point(292, 356);
            this.not_found.Name = "not_found";
            this.not_found.Size = new System.Drawing.Size(718, 52);
            this.not_found.TabIndex = 1;
            this.not_found.TabStop = false;
            // 
            // EditorNotFound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.not_found);
            this.Name = "EditorNotFound";
            this.Size = new System.Drawing.Size(1302, 764);
            this.Load += new System.EventHandler(this.EditorNotFound_Load);
            ((System.ComponentModel.ISupportInitialize)(this.not_found)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox not_found;
    }
}
