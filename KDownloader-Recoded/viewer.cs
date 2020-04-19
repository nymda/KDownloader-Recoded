using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public Form showing;
        public debugLog frmDebug;
        public bool console = false;
        public bool killSwitch = false;
        public bool lockClosure = true;
        public int deadThreads = 0;

        public bool ipTag = true;
        public Random rnd = new Random();
        public int threadCount;
        public List<String> ipAddrs = new List<String> { };
        public List<String> workingIps = new List<String> { };
        public bool useOutDir = true;
        public int ipaCount = 0;
        public List<List<String>> seperatedIpList = new List<List<String>> { };
        public camData setCamData;
        public string imgdir = "";
        public string outdir = "";
        public Font luc = new Font("Lucida Console", 15);
        public int remoteSaveCounter = 0;
        public int remoteTestcounter = 0;

        public List<Thread> dlThreads = new List<Thread> { };
        public List<shiftItem> shiftReg = new List<shiftItem> { };

        public viewer(int threadCount, camData cdat, string imgdir, string outdir, List<String> ips, Form showing, bool console, bool ipTag)
        {
            InitializeComponent();
            this.showing = showing;
            this.threadCount = threadCount;
            this.setCamData = cdat;
            this.imgdir = imgdir;
            this.outdir = outdir;
            this.console = console;
            this.ipTag = ipTag;
            ipAddrs = ips;
        }

        public void cPrint(Color c, string text)
        {
            if (console)
            {
                frmDebug.print(c, text);
            }
        }

        public List<Bitmap> rollingBitmapDisplay = new List<Bitmap> { };

        private void viewer_Load(object sender, EventArgs e)
        {
            frmDebug = new debugLog();
            if (console)
            {
                frmDebug.Show();
            }

            if(outdir == "")
            {
                useOutDir = false;
            }

            populateBlankImages();
            seperateAndSpawnThreads();
            ipaCount = ipAddrs.Count();
            this.Text = "Viewer | Progress: 0/" + ipaCount;
            BarMain.Maximum = ipaCount;
            showing.Hide();
            cPrint(Color.Green, "[M] Started viewer");
            frmDebug.setPosition((this.Left - frmDebug.Width + 10), this.Top, frmDebug.Width, this.Height);
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
                Thread testing = new Thread(() => mainTestThread(i, seperatedIpList[i], setCamData, imgdir, ipTag));
                testing.IsBackground = true;
                testing.Start();
                testing.Name = "[" + i.ToString() + "]";
                dlThreads.Add(testing);
                Thread.Sleep(500);
            }

            if(sanity == ipAddrs.Count())
            {
                cPrint(Color.DarkGreen, "[M] IP CHECK OK!");
            }
        }

        public void mainTestThread(int thrid, List<String> ips, camData cdat, string dir, bool DoIpTag)
        {
            string thridAsText = "[" + thrid + "] ";

            cPrint(Color.Black, thridAsText + "Starting thread");

            List<String> goodIps = new List<String> { };
            TimeWebClient wc = new TimeWebClient();
            wc.Credentials = cdat.Creds;

            foreach(string ip in ips)
            {
                //if the viewer form doesnt exist, exit the thread#
                if (killSwitch)
                {
                    //cPrint(Color.Red, thridAsText + "Close given! Killing myself!");
                    //break;
                }
                if (!this.IsHandleCreated)
                {
                    cPrint(Color.Red, thridAsText + "Handle lost! Killing myself!");
                    break;
                }

                remoteTestcounter++;
                this.Invoke(new MethodInvoker(delegate ()
                {
                    BarMain.Value = remoteTestcounter;
                    this.Text = "Viewer | Progress: " + remoteTestcounter + "/" + ipaCount;
                }));
                try
                {           
                    string intIp = ip;

                    if (intIp.EndsWith(":"))
                    {
                        intIp = intIp.Substring(0, intIp.Length - 1);
                    }

                    byte[] dlData = wc.DownloadData("http://" + intIp + cdat.Path);
                    cPrint(Color.DarkGreen, thridAsText + ip + " | 200");

                    Bitmap bmp;
                    Graphics g;
                    using (var ms = new MemoryStream(dlData))
                    {
                        bmp = new Bitmap(ms);
                    }
                    g = Graphics.FromImage(bmp);

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

                    if (DoIpTag)
                    {
                        g.FillRectangle(Brushes.Beige, 2, 2, largerWidth + 7, totalheight + 7);
                        g.FillRectangle(Brushes.Black, 5, 5, largerWidth, totalheight);
                        g.DrawString(intIp, luc, Brushes.White, new Point(6, 7));
                        g.DrawString(combinedCredsPT, luc, Brushes.White, new Point(5, 8 + (int)sizeOfIp.Height));
                    }
                    else
                    {
                        //not using the graphics object causes System.Runtime.InteropServices.ExternalException
                        g.FillRectangle(Brushes.Black, -1, -1, 1, 1);
                    }

                    remoteSaveCounter++;
                    workingIps.Add(ip);
                    int rscLen = remoteSaveCounter.ToString().Length;

                    string ipSafe = ip.Replace(".", "-");
                    ipSafe = ipSafe.Replace(":", "-");

                    string saveName = RandomString(5) + "-" + ipSafe + ".jpg";

                    if (useOutDir)
                    {
                        File.WriteAllLines(outdir, workingIps);
                    }

                    shiftReg.Insert(0, new shiftItem(bmp.Clone(new Rectangle(0, 0, bmp.Width, bmp.Height), PixelFormat.DontCare), saveName));
                    mainPB.Image = shiftReg[0].img;
                    subPBone.Image = shiftReg[1].img;
                    subPBtwo.Image = shiftReg[2].img;
                    subPBthree.Image = shiftReg[3].img;
                    subPBfour.Image = shiftReg[4].img;
                    subPBfive.Image = shiftReg[5].img;
                    subPBsix.Image = shiftReg[6].img;

                    Bitmap save = bmp.Clone(new Rectangle(0, 0, bmp.Width, bmp.Height), PixelFormat.DontCare);
                    save.Save(dir + "/" + saveName);
                    cPrint(Color.DarkGreen, thridAsText + "Wrote " + new FileInfo(dir + "/" + saveName).Length + " bytes to disk");

                    if (shiftReg.Count > 8)
                    {
                        shiftReg.RemoveRange(8, shiftReg.Count - 8);
                    }

                    save.Dispose();
                    bmp.Dispose();
                    g.Dispose();
                    GC.Collect();
                }
                catch(WebException ex)
                {
                    if (ex.Status == WebExceptionStatus.ProtocolError)
                    {
                        var response = ex.Response as HttpWebResponse;
                        if (response != null)
                        {
                            cPrint(Color.Gray, thridAsText + ip + " | " + (int)response.StatusCode);
                        }
                        else
                        {
                            cPrint(Color.Gray, thridAsText + ip + " | Null");
                        }
                    }
                    else
                    {
                        cPrint(Color.Gray, thridAsText + ip + " | Down");
                    }
                }
                catch
                {
                    //sometimes ThreadAbortException is thrown when killing threads, dont show any errors after killswitch is triggered.
                    if (!killSwitch)
                    {
                        cPrint(Color.Red, thridAsText + ip + " | Internal error");
                    }
                }
            }
            deadThreads++;
            cPrint(Color.Black, thridAsText + "Reaching end. Thread will exit.");
        }

        public void populateBlankImages()
        {
            Bitmap tm = new Bitmap(160, 85);
            Graphics tg = Graphics.FromImage(tm);
            tg.DrawRectangle(Pens.Black, -2, -2, -1, -1);

            shiftItem sf = new shiftItem(tm, "");

            for(int i = 0; i < 7; i++)
            {
                shiftReg.Add(sf);
            }

            mainPB.Image = shiftReg[0].img;
            subPBone.Image = shiftReg[1].img;
            subPBtwo.Image = shiftReg[2].img;
            subPBthree.Image = shiftReg[3].img;
            subPBfour.Image = shiftReg[4].img;
            subPBfive.Image = shiftReg[5].img;
            subPBsix.Image = shiftReg[6].img;
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
            if (lockClosure)
            {
                e.Cancel = true;
            }
            if (killSwitch)
            {
                cPrint(Color.Red, "[M] Wait for threads to terminate!");
            }
            else
            {
                cPrint(Color.Red, "[M] Close command given.");
                killSwitch = true;
                foreach (Thread t in dlThreads)
                {
                    deadThreads++;
                    t.Abort();
                    cPrint(Color.Red, "[M] Thread killed: " + t.Name);
                }
                killswitchTimer.Start();
            }
        }

        private void mainPB_Click(object sender, EventArgs e)
        {
            if(shiftReg[0].name != "") {
                Process.Start(imgdir + "/" + shiftReg[0].name);
            }
        }

        private void subPBone_Click(object sender, EventArgs e)
        {
            if (shiftReg[1].name != "")
            {
                Process.Start(imgdir + "/" + shiftReg[1].name);
            }
        }

        private void subPBtwo_Click(object sender, EventArgs e)
        {
            if (shiftReg[2].name != "")
            {
                Process.Start(imgdir + "/" + shiftReg[2].name);
            }
        }

        private void subPBthree_Click(object sender, EventArgs e)
        {
            if (shiftReg[3].name != "")
            {
                Process.Start(imgdir + "/" + shiftReg[3].name);
            }
        }

        private void subPBfour_Click(object sender, EventArgs e)
        {
            if (shiftReg[4].name != "")
            {
                Process.Start(imgdir + "/" + shiftReg[4].name);
            }
        }

        private void subPBfive_Click(object sender, EventArgs e)
        {
            if (shiftReg[5].name != "")
            {
                Process.Start(imgdir + "/" + shiftReg[5].name);
            }
        }

        private void subPBsix_Click(object sender, EventArgs e)
        {
            if (shiftReg[6].name != "")
            {
                Process.Start(imgdir + "/" + shiftReg[6].name);
            }
        }

        private void killswitchTimer_Tick(object sender, EventArgs e)
        {
            if((deadThreads + 1) >= threadCount)
            {
                lockClosure = false;
                frmDebug.Hide();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void Viewer_moved(object sender, EventArgs e)
        {
            if (console && frmDebug != null && CbDockConsole.Checked)
            {
                frmDebug.setPosition((this.Left - frmDebug.Width + 10), this.Top, frmDebug.Width, this.Height);
            }
        }

        private void Viewer_resized(object sender, EventArgs e)
        {
            if (console && frmDebug != null && CbDockConsole.Checked)
            {
                frmDebug.setPosition((this.Left - frmDebug.Width + 10), this.Top, frmDebug.Width, this.Height);
            }
        }

        private void viewer_focus(object sender, EventArgs e)
        {
            bringConsoleToFront.Start();
        }

        private void bringConsoleToFront_Tick(object sender, EventArgs e)
        {
            if (Form.ActiveForm == this)
            {
                frmDebug.Focus();
                this.Focus();
            }
            bringConsoleToFront.Stop();
        }

        private void CbDockConsole_CheckedChanged(object sender, EventArgs e)
        {
            if (CbDockConsole.Checked)
            {
                frmDebug.setPosition((this.Left - frmDebug.Width + 10), this.Top, frmDebug.Width, this.Height);
            }
        }
    }
}
