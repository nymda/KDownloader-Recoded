using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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

        public string b64 = "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";
        public Bitmap bmp;
        public Graphics gr;
        public Random rnd = new Random();
        public int r = 255;
        public int g = 0;
        public int b = 0;
        float frequency = 0.3f;

        private void about_Load(object sender, EventArgs e)
        {
            rainbow.Start();
            byte[] dat = Convert.FromBase64String(b64);
            using (MemoryStream ms = new MemoryStream(dat))
            {
                Bitmap nbmp = new Bitmap(ms);
                bmp = new Bitmap(nbmp);
                nbmp.Dispose();
            }
            gr = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
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

            pictureBox1.Image = monoLocked(bmp, Color.FromArgb(r, g, b));
        }

        public Bitmap monoLocked(Bitmap btm, Color c)
        {
            BitmapData BtmpDt = btm.LockBits(new Rectangle(0, 0, btm.Width, btm.Height), ImageLockMode.ReadWrite, btm.PixelFormat);
            IntPtr pointer = BtmpDt.Scan0;
            int size = Math.Abs(BtmpDt.Stride) * btm.Height;
            byte[] pixels = new byte[size];
            Marshal.Copy(pointer, pixels, 0, size);

            int counter = 0;
            List<int> rgbStore = new List<int> { };
            for (int b = 0; b < pixels.Length; b++)
            {
                if (counter == 3)
                {
                    //process bitmap here

                    if(pixels[b - 3] != 255 && pixels[b - 2] != 255 && pixels[b - 1] != 255)
                    {
                        pixels[b - 3] = c.R;
                        pixels[b - 2] = c.G;
                        pixels[b - 1] = c.B;
                        pixels[b] = 255;
                    }

                    //reset data for next chunk
                    counter = 0;
                    rgbStore = new List<int> { };
                }
                else
                {
                    counter++;
                    rgbStore.Add(pixels[b]);
                }
            }
            Marshal.Copy(pixels, 0, pointer, size);
            btm.UnlockBits(BtmpDt);

            return btm;
        }
    }
}
