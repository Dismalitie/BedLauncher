using System;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace BedLauncher
{
    public partial class World : UserControl
    {
        public static int WorldVersionType_Bedrock = 0;   
        public static int WorldVersionType_Preview = 1;   

                     string name; int worldVersionType;
        public World(string name, int worldVersionType)
        {
            InitializeComponent();
            this.name = name;
            this.worldVersionType = worldVersionType;
        }

        public void refresh() // stops the font resetting, triggers when tab activated
        {
            worldname.Font = Funcs.minecraftRegularFontReturnee(11);
        }

        private void World_Load(object sender, EventArgs e)
        {
            worldname.Font = Funcs.minecraftRegularFontReturnee(11);
            worldname.Text = name;

            refresh();
        }

        private void play_MouseEnter(object sender, EventArgs e)
        {
            play.BackgroundImage = Properties.Resources.world_play_hovered;
        }

        private void play_MouseLeave(object sender, EventArgs e)
        {
            play.BackgroundImage = Properties.Resources.world_play;
        }

        private void play_MouseDown(object sender, MouseEventArgs e)
        {
            play.BackgroundImage = Properties.Resources.world_play;

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

            if (worldVersionType == 1)
            {
                processStartInfo.Arguments = "/c start minecraft-preview://";
            }

            Process process = new Process
            {
                StartInfo = processStartInfo
            };

            process.Start();
        }

        private void play_MouseUp(object sender, MouseEventArgs e)
        {
            play.BackgroundImage = Properties.Resources.world_play_hovered;
        }
    }
}