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
    public partial class debugLog : Form
    {
        public debugLog()
        {
            InitializeComponent();
        }

        private void debugLog_Load(object sender, EventArgs e)
        {
            print("Starting : " + DateTime.Now);
        }

        public void print(string text)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                dbgList.Items.Insert(0, text);
            }));
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
