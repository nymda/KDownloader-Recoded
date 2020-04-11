using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDownloader_Recoded
{
    public partial class viewCdatValues : Form
    {
        public camData cd;

        public viewCdatValues(camData cd)
        {
            InitializeComponent();
            this.cd = cd;
        }

        private void viewCdatValues_Load(object sender, EventArgs e)
        {
            string response = "";
            response = response + "Path: " + cd.Path + "\n";
            response = response + "User: " + cd.Creds.UserName + "\n";
            response = response + "Pass: " + cd.Creds.Password + "\n";
            response = response + "Default: " + cd.IsDefault.ToString() + "\n";
            rtbView.Text = response;
        }
    }
}
