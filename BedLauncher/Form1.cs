using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BedLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string currentTab = "home";

        bool previewInstalled = true;
        bool editorInstalled = true;
        bool bedrockInstalled = true;

        HomeTab ht = new HomeTab { Dock = DockStyle.Fill, };
        PreviewTab pt = new PreviewTab { Dock = DockStyle.Fill };
        EditorTab et = new EditorTab { Dock = DockStyle.Fill };

        PreviewNotFound pnf = new PreviewNotFound { Dock = DockStyle.Fill };
        HomeNotFound hnf = new HomeNotFound { Dock = DockStyle.Fill };
        EditorNotFound enf = new EditorNotFound { Dock = DockStyle.Fill };

        private void Form1_Load(object sender, EventArgs e)
        {
            not_found.Location = new Point(tabcontainer.Width / 2 - not_found.Width / 2, tabcontainer.Height / 2 - not_found.Height / 2);

            if (string.IsNullOrEmpty(execPs("Get-AppxPackage -Name *MinecraftWindowsBeta*"))) // check if mcbe preview is installed
            {
                preview.BackgroundImage = Properties.Resources.preview_uninstalled;
                previewInstalled = false;
                editorInstalled = false;

                currentTab = "home";
                setTabs();
                home.BackgroundImage = Properties.Resources.home_pressed;

                tabcontainer.Controls.Add(pnf);
                pnf.Hide();
                tabcontainer.Controls.Add(enf);
                enf.Hide();
            }
            else
            {
                tabcontainer.Controls.Add(pt);
                tabcontainer.Controls.Add(et);
            }

            if (string.IsNullOrEmpty(execPs("Get-AppxPackage -Name *MinecraftUWP*"))) // check if mcbe is installed
            {
                home.BackgroundImage = Properties.Resources.home_uninstalled;
                bedrockInstalled = false;

                currentTab = "preview";
                setTabs();
                preview.BackgroundImage = Properties.Resources.preview_pressed;

                tabcontainer.Controls.Add(hnf);
                hnf.Hide();
            }
            else
            {
                tabcontainer.Controls.Add(ht);
            }

            ht.BringToFront();

            if (bedrockInstalled == false && previewInstalled == false)
            {
                setTabs();
            }
        }

        void setTabs()
        {
            if (bedrockInstalled)
            {
                home.BackgroundImage = Properties.Resources.home;
            }
            else
            {
                home.BackgroundImage = Properties.Resources.home_uninstalled;
            }

            if (previewInstalled)
            {
                preview.BackgroundImage = Properties.Resources.preview;
            }
            else
            {
                preview.BackgroundImage = Properties.Resources.preview_uninstalled;
            }

            if (editorInstalled)
            {
                editor.BackgroundImage = Properties.Resources.editor;
            }
            else
            {
                editor.BackgroundImage = Properties.Resources.editor_uninstalled;
            }
        }

        void setNotFounds()
        {
            pnf.SendToBack();
            pnf.Hide();

            hnf.SendToBack();
            hnf.Hide();

            enf.SendToBack();
            enf.Hide();
        }

        string execPs(string command)
        {
            // Initialize the process start info
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{command}\"",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            // Start the process
            using (Process process = new Process { StartInfo = processStartInfo })
            {
                process.Start();

                // Read the output
                string result = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                return result;
            }
        }

        // cls

        private void cls_MouseEnter(object sender, EventArgs e)
        {
            cls.BackgroundImage = Properties.Resources.x_hovered;
        }

        private void cls_MouseLeave(object sender, EventArgs e)
        {
            cls.BackgroundImage = Properties.Resources.x;
        }

        private void cls_MouseDown(object sender, MouseEventArgs e)
        {
            cls.BackgroundImage = Properties.Resources.x_pressed;
        }

        private void cls_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // min

        private void min_MouseEnter(object sender, EventArgs e)
        {
            min.BackgroundImage = Properties.Resources.min_hovered;
        }

        private void min_MouseLeave(object sender, EventArgs e)
        {
            min.BackgroundImage = Properties.Resources.min;
        }

        private void min_MouseDown(object sender, MouseEventArgs e)
        {
            min.BackgroundImage = Properties.Resources.min_pressed;
        }

        private void min_MouseUp(object sender, MouseEventArgs e)
        {
            min.BackgroundImage = Properties.Resources.min;
        }

        private void min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // home

        private void home_MouseEnter(object sender, EventArgs e)
        {
            if (currentTab != "home" && bedrockInstalled)
            {
                home.BackgroundImage = Properties.Resources.home_hovered;
            }
            if (currentTab != "home" && !bedrockInstalled)
            {
                home.BackgroundImage = Properties.Resources.home_uninstalled_hovered;
            }
        }

        private void home_MouseLeave(object sender, EventArgs e)
        {
            if (currentTab != "home" && bedrockInstalled)
            {
                home.BackgroundImage = Properties.Resources.home;
            }
            if (currentTab != "home" && !bedrockInstalled)
            {
                home.BackgroundImage = Properties.Resources.home_uninstalled;
            }
        }

        private void home_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentTab != "home" && bedrockInstalled)
            {
                currentTab = "home";
                setTabs();
                home.BackgroundImage = Properties.Resources.home_pressed;

                ht.BringToFront();
            }
            if (!bedrockInstalled)
            {
                // MessageBox.Show("Minecraft Bedrock Edition is not installed. Install it first to make it accessible in the launcher.", "BedLauncher - Bedrock not installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentTab = "home";
                setTabs();
                home.BackgroundImage = Properties.Resources.home_uninstalled_pressed;

                setNotFounds();
                hnf.BringToFront();
                hnf.Show();
            }
        }

        // preview

        private void preview_MouseEnter(object sender, EventArgs e)
        {
            if (currentTab != "preview" && previewInstalled)
            {
                preview.BackgroundImage = Properties.Resources.preview_hovered;
            }
            if (currentTab != "preview" && !previewInstalled)
            {
                preview.BackgroundImage = Properties.Resources.preview_uninstalled_hovered;
            }
        }

        private void preview_MouseLeave(object sender, EventArgs e)
        {
            if (currentTab != "preview" && previewInstalled)
            {
                preview.BackgroundImage = Properties.Resources.preview;
            }
            if (currentTab != "preview" && !previewInstalled)
            {
                preview.BackgroundImage = Properties.Resources.preview_uninstalled;
            }
        }

        private void preview_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentTab != "preview")
            {
                currentTab = "preview";
                setTabs();
                preview.BackgroundImage = Properties.Resources.preview_pressed;

                pt.BringToFront();
            }
            if (!previewInstalled)
            {
                // MessageBox.Show("Minecraft Preview is not installed. Install it first to make it accessible in the launcher.", "BedLauncher - Preview not installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentTab = "preview";
                setTabs();
                preview.BackgroundImage = Properties.Resources.preview_uninstalled_pressed;

                setNotFounds();
                pnf.BringToFront();
                pnf.Show();
            }
        }

        // editor

        private void editor_MouseEnter(object sender, EventArgs e)
        {
            if (currentTab != "editor" && editorInstalled)
            {
                editor.BackgroundImage = Properties.Resources.editor_hovered;
            }
            if (currentTab != "editor" && !editorInstalled)
            {
                editor.BackgroundImage = Properties.Resources.editor_uninstalled_hover;
            }
        }

        private void editor_MouseLeave(object sender, EventArgs e)
        {
            if (currentTab != "editor" && editorInstalled)
            {
                editor.BackgroundImage = Properties.Resources.editor;
            }
            if (currentTab != "editor" && !editorInstalled)
            {
                editor.BackgroundImage = Properties.Resources.editor_uninstalled;
            }
        }

        private void editor_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentTab != "editor")
            {
                currentTab = "editor";
                setTabs();
                editor.BackgroundImage = Properties.Resources.editor_pressed;

                et.BringToFront();
            }
            if (!previewInstalled)
            {
                // MessageBox.Show("Minecraft Preview is not installed. Install it first to make it accessible in the launcher.", "BedLauncher - Preview not installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentTab = "editor";
                setTabs();
                editor.BackgroundImage = Properties.Resources.preview_uninstalled_pressed;

                setNotFounds();
                enf.BringToFront();
                enf.Show();
            }
        }
    }
}