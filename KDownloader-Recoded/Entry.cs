using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

        public camData foscam = new camData("/snapshot.cgi", "foscam", new NetworkCredential("admin", ""), true);
        public camData sineoji = new camData("/tmpfs/auto.jpg", "sineoji", new NetworkCredential("user", "user"), true);

        public List<camData> pubDataList = new List<camData> { };
        public List<String> ipAddrs = new List<String> { };
        public string savePath = "";
        public string saveImgPath = "";
        public int ipCount = 0;
        public int threadCount = 4;

        public camData setCamData;

        private void Entry_Load(object sender, EventArgs e)
        {
            populateDefaultCdatItems();
            CDATselect.CheckOnClick = true;
            readCamConf();
        }

        public void populateDefaultCdatItems()
        {
            CDATselect.Items.Add(foscam.Name + " (default)");
            CDATselect.Items.Add(sineoji.Name + " (default)");
            pubDataList.Add(foscam);
            pubDataList.Add(sineoji);
            setCamData = foscam;
            CDATselect.SetItemChecked(0, true);
        }

        private void CDATselect_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < CDATselect.Items.Count; ++ix)
            {
                if (ix != e.Index) CDATselect.SetItemChecked(ix, false);
            }
            setCamData = pubDataList[e.Index];
        }

        public void updateEstTime()
        {
            int miliseconds = (ipCount * 500) / threadCount;
            TimeSpan t = TimeSpan.FromMilliseconds(miliseconds);
            string ans =  string.Format("{0:D2}h:{1:D2}m", t.Hours, t.Minutes);
            ESTlabel.Text = "EST. Time: " + ans;
        }

        private void inputSelect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Input File";
                dlg.Filter = "Text Files | *.txt";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    ipAddrs = System.IO.File.ReadAllLines(dlg.FileName).ToList();
                    ipCount = ipAddrs.Count();
                    LBcount.Text = "IP count: " + ipCount;
                    inputSelect.ForeColor = System.Drawing.Color.DarkGreen;
                    updateEstTime();
                }
            }
        }

        public void readCamConf()
        {
            string dir = Environment.CurrentDirectory;
            string confFile = dir + "/brands.conf";
            if (!File.Exists(confFile)){
                File.Create(confFile);
            }
            else
            {
                string[] rawConfData = File.ReadAllLines(confFile);
                foreach(string s in rawConfData)
                {
                    string[] splitCurrent = s.Split(':');
                    camData cdTemp = new camData(splitCurrent[1], splitCurrent[0], new NetworkCredential(splitCurrent[2], splitCurrent[3]), false);
                    CDATselect.Items.Add(cdTemp.Name);
                    pubDataList.Add(cdTemp);
                }
            }
        }

        private void NUDthreads_ValueChanged(object sender, EventArgs e)
        {
            threadCount = (int)NUDthreads.Value;
            updateEstTime();
        }

        private void btnViewCdat_Click(object sender, EventArgs e)
        {
            viewCdatValues vcd = new viewCdatValues(setCamData);
            vcd.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Text = "Start - Spawning Threads";

            this.Hide();

            if (CBrandOrd.Checked)
            {
                RNGCryptoServiceProvider rnd2 = new RNGCryptoServiceProvider();
                ipAddrs = ipAddrs.OrderBy(x => GetNextInt32(rnd2)).ToList();
            }

            using(var form = new viewer(threadCount, setCamData, saveImgPath, savePath, ipAddrs)){
                var res = form.ShowDialog();
                if (res == DialogResult.OK) {
                    this.Show();
                }
            }

            btnStart.Text = "Start";
            //viewer v = new viewer(threadCount, setCamData, saveImgPath, savePath, ipAddrs);
            //v.Show();
        }

        private void outputSelect_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Title = "Open Input File";
                dlg.Filter = "Text Files | *.txt";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    savePath = dlg.FileName;
                    outputSelect.ForeColor = System.Drawing.Color.DarkGreen;
                }
            }
        }

        private void folderSelect_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    saveImgPath = fbd.SelectedPath + "/";
                    folderSelect.ForeColor = System.Drawing.Color.DarkGreen;
                }
            }
        }

        public static int GetNextInt32(RNGCryptoServiceProvider rnd)
        {
            byte[] randomInt = new byte[4];
            rnd.GetBytes(randomInt);
            return Convert.ToInt32(randomInt[0]);
        }

        private void CBthreadDebug_CheckedChanged(object sender, EventArgs e)
        {
            //todo
        }
    }
}
