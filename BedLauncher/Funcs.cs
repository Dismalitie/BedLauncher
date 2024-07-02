using System.Drawing;
using System.Drawing.Text;
using System.Media;

namespace BedLauncher
{
    internal class Funcs
    {
        public static Font minecraftRegularFontReturnee(float sz)
        {
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile(".\\res\\MinecraftRegular.ttf");
            FontFamily fontFamily = privateFonts.Families[0];
            return new Font(fontFamily, sz);
        }

        public static void playClick()
        {
            if (Properties.Settings.Default.ClickSounds && Properties.Settings.Default.OldClick == false)
            {
                SoundPlayer player = new SoundPlayer(".\\res\\click.wav");
                player.Load();
                player.Play();

                player.Dispose();
            }

            if (Properties.Settings.Default.ClickSounds && Properties.Settings.Default.OldClick == true)
            {
                SoundPlayer player = new SoundPlayer(".\\res\\click_old.wav");
                player.Load();
                player.Play();

                player.Dispose();
            }
        }
    }
}
