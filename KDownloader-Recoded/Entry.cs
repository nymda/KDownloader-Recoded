using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
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
        public camData sineoji = new camData("/tmpfs/snap.jpg", "sineoji", new NetworkCredential("user", "user"), true);

        public string confFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/kdl/brands.conf";
        public string confDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/kdl/";

        public List<camData> pubDataList = new List<camData> { };
        public List<String> ipAddrs = new List<String> { };
        public string savePath = "";
        public string saveImgPath = "";
        public int ipCount = 0;
        public int threadCount = 4;
        public bool setInput = false;
        public bool setImage = false;

        public camData setCamData;

        public aspectRatio setAspectRatio = new aspectRatio(1280, 720);
        public aspectRatio template169 = new aspectRatio(1280, 720);
        public aspectRatio template43 = new aspectRatio(640, 480);
        public aspectRatio setTemplate;

        public bool isNormalising = true;
        public bool isStamping = true;
        public ipStyle setStyle = ipStyle.fancy;

        public Font font = new Font("Lucida Console", 15);

        private void Entry_Load(object sender, EventArgs e)
        {
            populateDefaultCdatItems();
            CDATselect.CheckOnClick = true;
            setTemplate = template169;
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
                    setInput = true;
                    if(setInput && setImage)
                    {
                        btnStart.Enabled = true;
                    }
                    ipAddrs = File.ReadAllLines(dlg.FileName).ToList();
                    ipCount = ipAddrs.Count();
                    LBcount.Text = "IP count: " + ipCount;
                    inputSelect.ForeColor = System.Drawing.Color.DarkGreen;
                    updateEstTime();
                }
            }
        }

        public void readCamConf()
        {
            if (!Directory.Exists(confDir)){
                Directory.CreateDirectory(confDir);
            }
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
            using (var vcd = new viewCdatValues(setCamData, CDATselect.SelectedIndex))
            {
                var res = vcd.ShowDialog();
                if (res == DialogResult.OK)
                {
                    CDATselect.Items.Clear();
                    pubDataList.Clear();
                    readCamConf();
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form loading = new spawningThreadMsg();
            loading.Show();

            this.Hide();

            if (CBrandOrd.Checked)
            {
                RNGCryptoServiceProvider rnd2 = new RNGCryptoServiceProvider();
                ipAddrs = ipAddrs.OrderBy(x => GetNextInt32(rnd2)).ToList();
            }

            entryViewerLink enl = new entryViewerLink();
            enl.threadCount = threadCount;
            enl.cdat = setCamData;
            enl.imgdir = saveImgPath;
            enl.outdir = savePath;
            enl.ips = ipAddrs;
            enl.showing = loading;
            enl.console = CBthreadDebug.Checked;
            enl.ipTag = cbIpStamp.Checked;
            enl.style = setStyle;
            enl.luc = font;
            enl.normaliseImage = isNormalising;
            enl.setAR = setAspectRatio;
            enl.normaliseImage = isNormalising;
            enl.setAR = setAspectRatio;

            using(var form = new viewer(enl)){
                var res = form.ShowDialog();
                if (res == DialogResult.OK) {
                    this.Show();
                }
            }
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
                    setImage = true;
                    if (setInput && setImage)
                    {
                        btnStart.Enabled = true;
                    }
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

        private void addCamera_Click(object sender, EventArgs e)
        {
            using (var form = new addCamBrand())
            {
                var res = form.ShowDialog();
                if (res == DialogResult.OK)
                {
                    CDATselect.Items.Clear();
                    pubDataList.Clear();
                    readCamConf();
                }
            }
        }

        private void ent_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E)
            {
                exploits ex = new exploits();
                ex.Show();
            }
            if(e.KeyCode == Keys.A)
            {
                about a = new about();
                a.Show();
            }
        }

        public aspectRatio calcAspectRatio(decimal oldX, decimal oldY, decimal newX)
        {
            decimal newY = (oldY / oldX) * newX;
            Console.WriteLine(newY);
            return new aspectRatio((int)newX, (int)newY);
        }

        private void nudWidth_ValueChanged(object sender, EventArgs e)
        {
            if(rb169.Checked || rb43.Checked)
            {
                aspectRatio nar = calcAspectRatio(setTemplate.width, setTemplate.height, (int)nudWidth.Value);
                setAspectRatio = nar;
                nudHeight.Value = nar.height;
            }
            else
            {
                setAspectRatio = new aspectRatio((int)nudWidth.Value, (int)nudHeight.Value);
            }
        }

        private void nudHeight_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void rb169_CheckedChanged(object sender, EventArgs e)
        {
            if (rb169.Checked)
            {
                setTemplate = template169;
                nudWidth.Value = setTemplate.width;
                nudHeight.Value = setTemplate.height;
                aspectRatio nar = calcAspectRatio(setTemplate.width, setTemplate.height, (int)nudWidth.Value);
                setAspectRatio = nar;
            }
        }

        private void rb43_CheckedChanged(object sender, EventArgs e)
        {
            if (rb43.Checked)
            {
                setTemplate = template43;
                nudWidth.Value = setTemplate.width;
                nudHeight.Value = setTemplate.height;
                aspectRatio nar = calcAspectRatio(setTemplate.width, setTemplate.height, (int)nudWidth.Value);
                setAspectRatio = nar;
            }
        }

        private void rbCustom_CheckedChanged(object sender, EventArgs e)
        {
            nudHeight.Enabled = rbCustom.Checked;
        }

        private void cbNormalise_CheckedChanged(object sender, EventArgs e)
        {
            rb169.Enabled = cbNormalise.Checked;
            rb43.Enabled = cbNormalise.Checked;
            rbCustom.Enabled = cbNormalise.Checked;
            nudWidth.Enabled = cbNormalise.Checked;
            isNormalising = cbNormalise.Checked;

            if (rb169.Checked || rb43.Checked)
            {
                nudHeight.Enabled = false;
            }
            else if (!cbNormalise.Checked)
            {
                nudHeight.Enabled = false;
            }
            else
            {
                nudHeight.Enabled = true;
            }
        }

        private void cbIpStamp_CheckedChanged(object sender, EventArgs e)
        {
            rbFancy.Enabled = cbIpStamp.Checked;
            rbBasic.Enabled = cbIpStamp.Checked;
            rbBarTop.Enabled = cbIpStamp.Checked;
            rbBarBottom.Enabled = cbIpStamp.Checked;
            btnFont.Enabled = cbIpStamp.Checked;
            isStamping = cbIpStamp.Checked;
        }

        private void rbFancy_CheckedChanged(object sender, EventArgs e)
        {
            setStyle = ipStyle.fancy;
        }

        private void rbBasic_CheckedChanged(object sender, EventArgs e)
        {
            setStyle = ipStyle.basic;
        }

        private void rbBarTop_CheckedChanged(object sender, EventArgs e)
        {
            setStyle = ipStyle.barTop;
        }

        private void rbBarBottom_CheckedChanged(object sender, EventArgs e)
        {
            setStyle = ipStyle.barBottom;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            setFontDialog.Font = font;
            if (setFontDialog.ShowDialog() != DialogResult.Cancel)
            {
                font = setFontDialog.Font;
            }
        }
    }
}
