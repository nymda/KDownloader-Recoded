using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
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
        public int ipCount = 0;
        public int threadCount = 1;

        public camData setCamData;

        private void Entry_Load(object sender, EventArgs e)
        {
            populateDefaultCdatItems();
            CDATselect.CheckOnClick = true;
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
    }
}
