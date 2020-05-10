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
