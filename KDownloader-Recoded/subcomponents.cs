using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KDownloader_Recoded
{
    class subcomponents
    {
        public camData resolveCamData(string cdat, string name = "noSetName")
        {
            string cdatRaw = Encoding.UTF8.GetString(Convert.FromBase64String(cdat));
            string[] cdatData = cdatRaw.Split(',');
            string path = cdatData[0];
            string username = cdatData[1];
            string password = cdatData[2];
            NetworkCredential nc = new NetworkCredential(username, password);
            return new camData(path, name, nc, false);
        }
    }

    public class camData
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public NetworkCredential Creds { get; set; }
        public bool IsDefault { get; set; }

        public camData(string path, string name, NetworkCredential credentials, bool isDefault)
        {
            this.Path = path;
            this.Name = name;
            this.Creds = credentials;
            this.IsDefault = isDefault;    
        }
    }

    public class colourItem
    {
        public Color ItemColor { get; set; }
        public string Message { get; set; }

        public colourItem(Color c, string m)
        {
            ItemColor = c;
            Message = m;
        }
    }

    public class shiftItem
    {
        public Bitmap img { get; set; }
        public string name { get; set; }
        public string ipAdr { get; set; }
        public shiftItem(Bitmap img, string name, string ipAdr)
        {
            this.img = img;
            this.name = name;
            this.ipAdr = ipAdr;
        }

        public void dispose()
        {
            img.Dispose();
            name = null;
        }
    }

    public class TimeWebClient : WebClient
    {
        protected override WebRequest GetWebRequest(Uri address)
        {
            var req = base.GetWebRequest(address);
            req.Timeout = 5000;
            return req;
        }
    }

    public class rndFuncs
    {
        public string RandomString(int length)
        {
            Random rnd = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[rnd.Next(s.Length)]).ToArray());
        }
    }
}
