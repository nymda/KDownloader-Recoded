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
            print(Color.Black, "[M] Starting : " + DateTime.Now);
        }

        public void print(Color c, string text)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                dbgList.Items.Insert(0, new colourItem(c, text));
            }));
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void dbg_drawitem(object sender, DrawItemEventArgs e)
        {
            colourItem item = dbgList.Items[e.Index] as colourItem;
            if (item != null)
            {
                e.Graphics.DrawString(item.Message, dbgList.Font, new SolidBrush(item.ItemColor), 0, e.Index * dbgList.ItemHeight);
            }
            else
            {

            }
        }

        public void setPosition(int x, int y, int width, int height)
        {
            this.Top = y;
            this.Left = x;
            this.Width = width;
            this.Height = height;
        }
    }
}
