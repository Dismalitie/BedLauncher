using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BedLauncher
{
    public partial class PreviewTab : UserControl
    {
        public PreviewTab()
        {
            InitializeComponent();
        }

        private void PreviewTab_Load(object sender, EventArgs e)
        {
            launch.Location = new Point((Width / 2) - (launch.Width / 2), launch.Location.Y);
        }

        private void launch_MouseEnter(object sender, EventArgs e)
        {
            launch.BackgroundImage = Properties.Resources.launch_preview_hovered;
        }

        private void launch_MouseLeave(object sender, EventArgs e)
        {
            launch.BackgroundImage = Properties.Resources.launch_preview;
        }

        private void launch_MouseDown(object sender, MouseEventArgs e)
        {
            launch.BackgroundImage = Properties.Resources.launch_preview_pressed;
        }

        private void launch_MouseUp(object sender, MouseEventArgs e)
        {
            launch.BackgroundImage = Properties.Resources.launch_preview_hovered;
        }

        private void launch_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c start minecraft-preview://", // launch via url
                UseShellExecute = false,
                RedirectStandardOutput = false,
                CreateNoWindow = false
            };

            Process process = new Process
            {
                StartInfo = processStartInfo
            };

            process.Start();
        }
    }
}
