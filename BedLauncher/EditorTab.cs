using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BedLauncher
{
    public partial class EditorTab : UserControl
    {
        public EditorTab()
        {
            InitializeComponent();
        }

        public void refresh()
        {
            overview_tutorial_name.Font = Funcs.minecraftRegularFontReturnee(11);
            tutorial_tutorial_name.Font = Funcs.minecraftRegularFontReturnee(11);
            extensions_tutorial_name.Font = Funcs.minecraftRegularFontReturnee(11);
        }

        private void EditorTab_Load(object sender, EventArgs e)
        {
            launch.Location = new Point((Width / 2) - (launch.Width / 2), launch.Location.Y);
        }

        private void launch_MouseEnter(object sender, EventArgs e)
        {
            launch.BackgroundImage = Properties.Resources.launch_editor_hovered;
        }

        private void launch_MouseLeave(object sender, EventArgs e)
        {
            launch.BackgroundImage = Properties.Resources.launch_editor;
        }

        private void launch_MouseDown(object sender, MouseEventArgs e)
        {
            launch.BackgroundImage = Properties.Resources.launch_editor_pressed;
        }

        private void launch_MouseUp(object sender, MouseEventArgs e)
        {
            launch.BackgroundImage = Properties.Resources.launch_editor_hovered;
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
                Arguments = "/c start minecraft-preview:?Editor=true", // launch via url
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

        // overview tutorial launch

        private void overview_tutorial_launch_MouseEnter(object sender, EventArgs e)
        {
            overview_tutorial_launch.BackgroundImage = Properties.Resources.open_browser_hovered;
        }

        private void overview_tutorial_launch_MouseLeave(object sender, EventArgs e)
        {
            overview_tutorial_launch.BackgroundImage = Properties.Resources.open_browser;
        }

        private void overview_tutorial_launch_MouseDown(object sender, MouseEventArgs e)
        {
            overview_tutorial_launch.BackgroundImage = Properties.Resources.open_browser;

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
                Arguments = "/c start https://learn.microsoft.com/en-us/minecraft/creator/documents/editoroverview?view=minecraft-bedrock-stable", // launch via url
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

        // tutorial tutorial launch

        private void overview_tutorial_launch_MouseUp(object sender, MouseEventArgs e)
        {
            overview_tutorial_launch.BackgroundImage = Properties.Resources.open_browser_hovered;
        }

        private void tutorial_tutorial_launch_MouseEnter(object sender, EventArgs e)
        {
            tutorial_tutorial_launch.BackgroundImage = Properties.Resources.open_browser_hovered;
        }

        private void tutorial_tutorial_launch_MouseLeave(object sender, EventArgs e)
        {
            tutorial_tutorial_launch.BackgroundImage = Properties.Resources.open_browser;
        }

        private void tutorial_tutorial_launch_MouseDown(object sender, MouseEventArgs e)
        {
            tutorial_tutorial_launch.BackgroundImage = Properties.Resources.open_browser;

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
                Arguments = "/c start https://learn.microsoft.com/en-us/minecraft/creator/documents/editortutorial?view=minecraft-bedrock-stable", // launch via url
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

        private void tutorial_tutorial_launch_MouseUp(object sender, MouseEventArgs e)
        {
            tutorial_tutorial_launch.BackgroundImage = Properties.Resources.open_browser_hovered;
        }

        // extensions tutorial launch

        private void extensions_tutorial_launch_MouseEnter(object sender, EventArgs e)
        {
            extensions_tutorial_launch.BackgroundImage = Properties.Resources.open_browser_hovered;
        }

        private void extensions_tutorial_launch_MouseLeave(object sender, EventArgs e)
        {
            extensions_tutorial_launch.BackgroundImage = Properties.Resources.open_browser;
        }

        private void extensions_tutorial_launch_MouseDown(object sender, MouseEventArgs e)
        {
            extensions_tutorial_launch.BackgroundImage = Properties.Resources.open_browser;

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
                Arguments = "/c start https://learn.microsoft.com/en-us/minecraft/creator/documents/editorextensionsintroduction?view=minecraft-bedrock-stable", // launch via url
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

        private void extensions_tutorial_launch_MouseUp(object sender, MouseEventArgs e)
        {
            extensions_tutorial_launch.BackgroundImage = Properties.Resources.open_browser_hovered;
        }
    }
}
