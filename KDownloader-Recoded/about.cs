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
        public int r = 255;
        public int g = 0;
        public int b = 0;
        float frequency = 0.3f;

        private void about_Load(object sender, EventArgs e)
        {
            rainbow.Start();
        }

        public int i = 0;
        private void rainbow_Tick(object sender, EventArgs e)
        {
            if(i == 32)
            {
                i = 0;
            }

            i++;

            r = (int)Math.Round(Math.Sin((frequency * i) + 0) * 127 + 128) / 2;
            g = (int)Math.Round(Math.Sin((frequency * i) + 2) * 127 + 128) / 2;
            b = (int)Math.Round(Math.Sin((frequency * i) + 4) * 127 + 128) / 2;

            aboutRTB.ForeColor = Color.FromArgb(r, g, b);
        }
    }
}
