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
    public partial class viewer : Form
    {
        public int threadCount;
        public List<String> ipAddrs = new List<String> { };
        public List<List<String>> seperatedIpList = new List<List<String>> { };
        public camData setCamData;
        public string dir = "";
        public Font luc = new Font("Lucida Console", 10);
        public List<Bitmap> imgStore = new List<Bitmap> { };

        public viewer(int threadCount, camData cdat, string dir)
        {
            InitializeComponent();
            this.threadCount = threadCount;
            this.setCamData = cdat;
            this.dir = dir;
        }

        public List<Bitmap> rollingBitmapDisplay = new List<Bitmap> { };

        private void viewer_Load(object sender, EventArgs e)
        {
            seperateAndSpawnThreads();
        }

        public void seperateAndSpawnThreads()
        {
            //populate list with empty lists
            foreach(string s in ipAddrs)
            {
                seperatedIpList.Add(new List<string> { });
            }

            //add ip data to individual lists
            int extCount = 0;
            foreach (string s in ipAddrs)
            {
                if(extCount != threadCount)
                {
                    extCount++;
                    seperatedIpList[extCount].Add(s);
                }
                else
                {
                    extCount = 0;
                }
            }

            //spawn threads
            for (int i = 0; i < threadCount; i++)
            {
                Thread a = new Thread(() => mainTestThread(i, seperatedIpList[i], setCamData, ""));
                a.IsBackground = true;
                a.Start();
                Thread.Sleep(500);
            }
        }

        public void mainTestThread(int thrid, List<String> ips, camData cdat, string dir)
        {
            List<String> goodIps = new List<String> { };
            TimeWebClient wc = new TimeWebClient();
            wc.Credentials = cdat.Creds;
            Console.WriteLine("thread spawned: " + thrid);

            foreach(string ip in ips)
            {
                try
                {
                    byte[] dlData = wc.DownloadData("http://" + ips + cdat.Path);
                    Bitmap bmp;
                    Graphics g;
                    using (var ms = new MemoryStream(dlData))
                    {
                        bmp = new Bitmap(ms);
                    }
                    g = Graphics.FromImage(bmp);

                    //entire chunk of mess for drawing the ip thing
                    SizeF sizeOfIp = g.MeasureString(ip, luc);
                    g.FillRectangle(Brushes.Black, 3, 3, sizeOfIp.Width + 1, sizeOfIp.Height + 1);
                    g.DrawString(ip, luc, Brushes.Wheat, new Point(4, 4));
                    String combinedCredsPT = cdat.Creds.UserName + " : " + cdat.Creds.Password;
                    SizeF sizeOfCreds = g.MeasureString(combinedCredsPT, luc);
                    g.FillRectangle(Brushes.Black, 3, 4 + sizeOfIp.Height, sizeOfCreds.Width + 1, sizeOfCreds.Height + 1);
                    g.DrawString(combinedCredsPT, luc, Brushes.White, new Point(4 + (int)sizeOfIp.Height, 4));

                    imgStore.Insert(0, bmp);
                    if(imgStore.Count > 5)
                    {
                        for(int i = 5; i < imgStore.Count; i++)
                        {
                            imgStore.RemoveAt(i);
                        }
                    }
                }
                catch
                {

                }
            }
        }

        public class TimeWebClient : WebClient
        {
            protected override WebRequest GetWebRequest(Uri address)
            {
                var req = base.GetWebRequest(address);
                req.Timeout = 5000;
                return req;
            }
        }
    }
}
