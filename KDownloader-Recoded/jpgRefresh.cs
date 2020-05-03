using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDownloader_Recoded
{
    public partial class jpgRefresh : Form
    {

        public Uri setUri;
        public Thread imgGet;
        public Bitmap extBitmap = new Bitmap(1, 1);
        string rawTitle;
        public int prevTime = 0;
        public Stopwatch st = new Stopwatch();

        public jpgRefresh(Uri setUri)
        {
            InitializeComponent();
            this.setUri = setUri;
        }

        private void jpgRefresh_Load(object sender, EventArgs e)
        {
            rawTitle = "Image refresh view | " + setUri.ToString() + " | ";
            imgGet = new Thread(() => updateDisplayRemote());
            imgGet.IsBackground = true;
            imgGet.Start();
        }

        public void updateDisplayRemote()
        {
            TimeWebClient w = new TimeWebClient();
            for(; ; )
            {
                st.Start();
                byte[] data = w.DownloadData(setUri);
                using (var ms = new MemoryStream(data))
                {
                    extBitmap = new Bitmap(ms);
                }
                this.Invoke(new MethodInvoker(delegate ()
                {
                    this.Text = rawTitle + prevTime + "ms";
                    pictureBox1.Image = extBitmap;
                }));
                st.Stop();
                prevTime = (int)st.ElapsedMilliseconds;
                st.Reset();
                Console.WriteLine("Got frame");
                Thread.Sleep(250);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            imgGet.Abort();
        }
    }
}
