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
    public partial class addCamBrand : Form
    {
        public addCamBrand()
        {
            InitializeComponent();
        }

        private void addCamBrand_Load(object sender, EventArgs e)
        {
            ToolTip TTpathHelp = new ToolTip();
            TTpathHelp.ShowAlways = true;
            TTpathHelp.SetToolTip(LblShowPathHelp, "Path: The snapshot url of the camera, without the IP. (IE: /system/snapshot.jpg)");
        }

        private void CBnoUser_CheckedChanged(object sender, EventArgs e)
        {
            if (CBnoUser.Checked)
            {
                UserInput.Enabled = false;
                UserInput.Text = "None";
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
                PassInput.Text = "None";
            }
            else
            {
                PassInput.Enabled = true;
                PassInput.Text = "";
            }
        }
    }
}
