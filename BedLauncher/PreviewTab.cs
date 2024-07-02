using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BedLauncher
{
    public partial class PreviewTab : UserControl
    {
        public PreviewTab()
        {
            InitializeComponent();
        }

        public void refresh()
        {
            foreach (World w in worldContainer.Controls)
            {
                w.refresh();
            }
        }

        private void PreviewTab_Load(object sender, EventArgs e)
        {
            launch.Location = new Point((Width / 2) - (launch.Width / 2), launch.Location.Y);

            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\Packages\\Microsoft.MinecraftWindowsBeta_8wekyb3d8bbwe\\LocalState\\games\\com.mojang\\minecraftWorlds\\";

            int i = 0;

            foreach (string dir in Directory.EnumerateDirectories(path))
            {
                i++;
                if (i < 4)
                {
                    World w = new World(File.ReadAllText(dir + "\\levelname.txt"), World.WorldVersionType_Preview);
                    worldContainer.Controls.Add(w);
                }
            }
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
