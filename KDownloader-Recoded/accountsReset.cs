using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace KDownloader_Recoded
{
    public partial class accountsReset : Form
    {
        //thanks bp2008!
        //implementation by me

        public TimeWebClient w = new TimeWebClient();
        public string uri;
        public int newestUID;
        public readonly string secret_key = "?auth=YWRtaW46MTEK";
        public accountsReset(string uri)
        {
            InitializeComponent();
            this.uri = uri;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void accountsReset_Load(object sender, EventArgs e)
        {
            print(Color.Black, "Getting accounts...");
            string rawXml = w.DownloadString(uri + "/Security/users" + secret_key);
            XmlDocument xmld = new XmlDocument();
            xmld.LoadXml(rawXml);
            XmlNodeList Users = xmld.GetElementsByTagName("User");
            foreach (XmlNode user in Users)
            {
                string nUser = "UID " + user["id"].InnerText + " : " + user["userName"].InnerText;
                newestUID = Int32.Parse(user["id"].InnerText);
                accListBox.Items.Add(nUser);
            }
            print(Color.DarkGreen, "Found " + accListBox.Items.Count + " account(s)");
            readonlyUIDtb.Text = (newestUID + 1).ToString();
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

        private void setPwdBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string[] selectedUser = accListBox.SelectedItem.ToString().Split(':');
                string rawId = selectedUser[0].Substring(4);
                rawId = rawId.Replace(" ", "");
                string rawName = selectedUser[1].Substring(1);
                print(Color.Orange, "Setting password for " + rawName);
                string completedXml = buildXmlData(rawId, rawName, newPwBox.Text);
                w.UploadString(uri + "/Security/users/" + rawId + secret_key, "PUT", completedXml);
                print(Color.Green, "Set password to " + newPwBox.Text);
            }
            catch
            {
                print(Color.Red, "(password too weak?)");
                print(Color.Red, "Password set failed");
            }
        }

        private void createAccBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string rawId = (newestUID + 1).ToString();
                string rawName = tbUsername.Text;
                print(Color.Orange, "Creating account " + rawName);
                print(Color.Orange, "Setting password to " + tbPassword.Text);
                string completedXml = buildXmlData(rawId, rawName, tbPassword.Text);
                w.UploadString(uri + "/Security/users/" + rawId + secret_key, "PUT", completedXml);
                print(Color.Green, "Created account " + rawName);
            }
            catch
            {
                print(Color.Red, "(password too weak?)");
                print(Color.Red, "Account creation failed");
            }
        }

        public string buildXmlData(string uid, string name, string pass)
        {
            string userXml =
            @"<User version=""1.0"" xmlns=""http://www.hikvision.com/ver10/XMLSchema"">
	            <id>" + uid + @"</id>
                <priority>high</priority>
	            <userName>" + name + @"</userName>
	            <password>" + pass + @"</password>
            </User>";
            return userXml;
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


    }
}
