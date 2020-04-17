using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDownloader_Recoded
{
    public partial class viewCdatValues : Form
    {
        public camData cd;
        public int index;
        public string confFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/kdl/brands.conf";
        public List<String> lines = new List<String> { };

        public viewCdatValues(camData cd, int index)
        {
            InitializeComponent();
            this.cd = cd;
            this.index = index;
        }

        private void viewCdatValues_Load(object sender, EventArgs e)
        {
            index = index -= 2;

            lines = File.ReadAllLines(confFile).ToList();

            Console.WriteLine(lines.Count());

            if (cd.IsDefault == true)
            {
                cbConfirmDelete.Enabled = false;
            }

            string response = "";
            response = response + "Name: " + cd.Name + "\n";
            response = response + "Path: " + cd.Path + "\n";
            response = response + "User: " + cd.Creds.UserName + "\n";
            response = response + "Pass: " + cd.Creds.Password + "\n";
            response = response + "Default: " + cd.IsDefault.ToString() + "\n";
            rtbView.Text = response;
        }

        private void btnDeleteCdat_Click(object sender, EventArgs e)
        {
            lines.RemoveAt(index);
            File.WriteAllLines(confFile, lines);

            Thread.Sleep(500);

            this.DialogResult = DialogResult.OK;
        }

        private void cbConfirmDelete_CheckedChanged(object sender, EventArgs e)
        {
            btnDeleteCdat.Enabled = cbConfirmDelete.Checked;
        }
    }
}
