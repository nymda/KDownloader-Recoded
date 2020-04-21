using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDownloader_Recoded
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        public Random rnd = new Random();

        private void about_Load(object sender, EventArgs e)
        {
            rainbow.Start();
        }

        private void rainbow_Tick(object sender, EventArgs e)
        {
            int r = rnd.Next(0, 128);
            int g = rnd.Next(0, 128);
            int b = rnd.Next(0, 128);
            aboutRTB.ForeColor = Color.FromArgb(r, g, b);
        }
    }
}
