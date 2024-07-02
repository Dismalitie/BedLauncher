using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BedLauncher
{
    public partial class SettingsTab : UserControl
    {
        public SettingsTab()
        {
            InitializeComponent();
        }

        public void refresh()
        {
            clicksounds_label.Font = Funcs.minecraftRegularFontReturnee(11);
            oldclick_label.Font = Funcs.minecraftRegularFontReturnee(11);
            launchsounds_label.Font = Funcs.minecraftRegularFontReturnee(11);
            verNum.Font = Funcs.minecraftRegularFontReturnee(11);
        }

        private void SettingsTab_Load(object sender, EventArgs e)
        {
            verNum.Text = "v" + Properties.Settings.Default.Version;

            if (Properties.Settings.Default.ClickSounds)
                clicksounds_toggle.BackgroundImage = Properties.Resources.toggle_on;

            if (Properties.Settings.Default.OldClick)
                oldclick_toggle.BackgroundImage = Properties.Resources.toggle_on;

            if (Properties.Settings.Default.LaunchSounds)
                launchsounds_toggle.BackgroundImage = Properties.Resources.toggle_on;
        }

        // gh link

        private void verNum_MouseEnter(object sender, EventArgs e)
        {
            verNum.ForeColor = Color.FromArgb(60, 133, 39);
        }

        private void verNum_MouseLeave(object sender, EventArgs e)
        {
            verNum.ForeColor = Color.White;
        }

        private void verNum_MouseDown(object sender, MouseEventArgs e)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c start https://www.github.com/dismalitie/bedlauncher", // launch via url
                UseShellExecute = false,
                RedirectStandardOutput = false,
                CreateNoWindow = false,
            };

            Process process = new Process
            {
                StartInfo = processStartInfo
            };

            process.Start();
        }

        // clicksounds

        private void clicksounds_toggle_MouseEnter(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ClickSounds)
                clicksounds_toggle.BackgroundImage = Properties.Resources.toggle_on_hovered;
            if (!Properties.Settings.Default.ClickSounds)
                clicksounds_toggle.BackgroundImage = Properties.Resources.toggle_off_hovered;
        }

        private void clicksounds_toggle_MouseLeave(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ClickSounds)
                clicksounds_toggle.BackgroundImage = Properties.Resources.toggle_on;
            if (!Properties.Settings.Default.ClickSounds)
                clicksounds_toggle.BackgroundImage = Properties.Resources.toggle_off;
        }

        private void clicksounds_toggle_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ClickSounds = !Properties.Settings.Default.ClickSounds;

            if (Properties.Settings.Default.ClickSounds)
                clicksounds_toggle.BackgroundImage = Properties.Resources.toggle_on_hovered;
            if (!Properties.Settings.Default.ClickSounds)
                clicksounds_toggle.BackgroundImage = Properties.Resources.toggle_off_hovered;

            Funcs.playClick();
        }

        // oldclick

        private void oldclick_toggle_MouseEnter(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.OldClick)
                oldclick_toggle.BackgroundImage = Properties.Resources.toggle_on_hovered;
            if (!Properties.Settings.Default.OldClick)
                oldclick_toggle.BackgroundImage = Properties.Resources.toggle_off_hovered;
        }

        private void oldclick_toggle_MouseLeave(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.OldClick)
                oldclick_toggle.BackgroundImage = Properties.Resources.toggle_on;
            if (!Properties.Settings.Default.OldClick)
                oldclick_toggle.BackgroundImage = Properties.Resources.toggle_off;
        }

        private void oldclick_toggle_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.OldClick = !Properties.Settings.Default.OldClick;

            if (Properties.Settings.Default.OldClick)
                oldclick_toggle.BackgroundImage = Properties.Resources.toggle_on_hovered;
            if (!Properties.Settings.Default.OldClick)
                oldclick_toggle.BackgroundImage = Properties.Resources.toggle_off_hovered;

            Funcs.playClick();
        }

        // launchsounds

        private void launchsounds_toggle_MouseEnter(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.LaunchSounds)
                launchsounds_toggle.BackgroundImage = Properties.Resources.toggle_on_hovered;
            if (!Properties.Settings.Default.LaunchSounds)
                launchsounds_toggle.BackgroundImage = Properties.Resources.toggle_off_hovered;
        }

        private void launchsounds_toggle_MouseLeave(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.LaunchSounds)
                launchsounds_toggle.BackgroundImage = Properties.Resources.toggle_on;
            if (!Properties.Settings.Default.LaunchSounds)
                launchsounds_toggle.BackgroundImage = Properties.Resources.toggle_off;
        }

        private void launchsounds_toggle_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.LaunchSounds = !Properties.Settings.Default.LaunchSounds;

            if (Properties.Settings.Default.LaunchSounds)
                launchsounds_toggle.BackgroundImage = Properties.Resources.toggle_on_hovered;
            if (!Properties.Settings.Default.LaunchSounds)
                launchsounds_toggle.BackgroundImage = Properties.Resources.toggle_off_hovered;

            Funcs.playClick();
        }
    }
}
