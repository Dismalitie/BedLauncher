using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BedLauncher
{
    public partial class HomeNotFound : UserControl
    {
        public HomeNotFound()
        {
            InitializeComponent();
        }

        private void HomeNotFound_Load(object sender, EventArgs e)
        {
            not_found.Location = new Point(Width / 2 - not_found.Width / 2, Height / 2 - not_found.Height / 2);
        }
    }
}
