using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDownloader_Recoded
{
    public partial class addCamBrand : Form
    {
        public addCamBrand()
        {
            InitializeComponent();
        }

        public string confFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/kdl/brands.conf";
        public string confDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/kdl/";
        public List<String> lines = new List<String> { };

        public bool setUser = true;
        public bool setPass = true;

        public string name = "";
        public string path = "";
        public string user = "";
        public string pass = "";

        private void addCamBrand_Load(object sender, EventArgs e)
        {
            ToolTip TTpathHelp = new ToolTip();
            TTpathHelp.ShowAlways = true;
            TTpathHelp.SetToolTip(LblShowPathHelp, "Path: The snapshot url of the camera, without the IP. (IE: /system/snapshot.jpg)");
            lines = File.ReadAllLines(confFile).ToList();
        }

        private void CBnoUser_CheckedChanged(object sender, EventArgs e)
        {
            if (CBnoUser.Checked)
            {
                UserInput.Enabled = false;
                UserInput.Text = "Null";
            }
            else
            {
                UserInput.Enabled = true;
                UserInput.Text = "";
            }
        }

        private void CBnoPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CBnoPass.Checked)
            {
                PassInput.Enabled = false;
                PassInput.Text = "Null";
            }
            else
            {
                PassInput.Enabled = true;
                PassInput.Text = "";
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(UserInput.Text == "")
            {
                UserInput.Enabled = false;
                UserInput.Text = "Null";
            }
            if (PassInput.Text == "")
            {
                PassInput.Enabled = false;
                PassInput.Text = "Null";
            }

            name = NameInput.Text;
            path = PathInput.Text;
            user = UserInput.Text;
            pass = PassInput.Text;

            string compiled = name + ":" + path + ":" + user + ":" + pass + ":false";

            lines.Add(compiled);

            File.WriteAllLines(confFile, lines);

            this.DialogResult = DialogResult.OK;
        }
    }
}
