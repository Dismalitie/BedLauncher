using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace BedLauncher
{
    public partial class HomeTab : UserControl
    {
        public HomeTab()
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

        public int refreshCount = 0;

        private void HomeTab_Load(object sender, EventArgs e)
        {
            launch.Location = new Point((Width / 2) - (launch.Width / 2), launch.Location.Y);

            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\Packages\\Microsoft.MinecraftUWP_8wekyb3d8bbwe\\LocalState\\games\\com.mojang\\minecraftWorlds\\";

            int i = 0;

            foreach (string dir in Directory.EnumerateDirectories(path))
            {
                i++;
                if (i < 4)
                {
                    World w = new World(File.ReadAllText(dir + "\\levelname.txt"), World.WorldVersionType_Bedrock);
                    w.refresh();
                    worldContainer.Controls.Add(w);

                    refresh();
                }
                refresh();
            }

            refresh();
        }

        private void launch_MouseEnter(object sender, EventArgs e)
        {
            launch.BackgroundImage = Properties.Resources.launch_home_hovered;
        }

        private void launch_MouseLeave(object sender, EventArgs e)
        {
            launch.BackgroundImage = Properties.Resources.launch_home;
        }

        private void launch_MouseDown(object sender, MouseEventArgs e)
        {
            launch.BackgroundImage = Properties.Resources.launch_home_pressed;
        }

        private void launch_MouseUp(object sender, MouseEventArgs e)
        {
            launch.BackgroundImage = Properties.Resources.launch_home_hovered;
        }

        private void launch_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.LaunchSounds)
            {
                SoundPlayer player = new SoundPlayer(".\\res\\click.wav");
                player.Load();
                player.Play();

                player.Dispose();
            }

            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c start minecraft://", // launch via url
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

        // refresh

        private void refresher_Tick(object sender, EventArgs e) // needed because for some reason fonts just wont work with refresh() on startup
        {
            if (refreshCount < 100)
            {
                refreshCount++;
                refresh();
            }
            else { refresher.Enabled = false; }
        }
    }
}
