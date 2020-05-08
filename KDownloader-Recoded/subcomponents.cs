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

    public class graphicsHandler
    {
        public Bitmap canvas = new Bitmap(1, 1);
        public Graphics g;
        public Bitmap generateStamp(string ip, string userpass, Font font, int imgWidth, ipStyle style = ipStyle.fancy)
        {
            canvas = new Bitmap(1, 1);
            Graphics g = Graphics.FromImage(canvas);

            SizeF _ipSize = g.MeasureString(ip, font);
            SizeF _upSize = g.MeasureString(userpass, font);
            int setWidth = 0;

            if (_ipSize.Width > _upSize.Width)
            {
                setWidth = (int)_ipSize.Width;
            }
            else
            {
                setWidth = (int)_upSize.Width;
            }

            //leave space for a 2px buffer
            setWidth = setWidth + 12;
            int setHeight = (int)_ipSize.Height + (int)_upSize.Height + 12;

            canvas.Dispose();
            g.Dispose();

            if(style == ipStyle.fancy)
            {
                canvas = new Bitmap(setWidth, setHeight);
                g = Graphics.FromImage(canvas);

                Color midGray = Color.FromArgb(128, 128, 128);
                Color vDarkGray = Color.FromArgb(64, 64, 64);
                Pen FourPxBlack = new Pen(Brushes.Black, 8);
                Pen TwoPxLGray = new Pen(midGray, 4);
                Pen OnePxVDarkGray = new Pen(vDarkGray, 2);
                g.FillRectangle(Brushes.LightGray, 0, 0, setWidth, setHeight);
                g.DrawRectangle(FourPxBlack, 2, 2, setWidth - 4, setHeight - 4);
                g.DrawRectangle(TwoPxLGray, 1, 1, setWidth - 2, setHeight - 2);
                g.DrawLine(OnePxVDarkGray, 0, 0, 0, setHeight);
                g.DrawLine(OnePxVDarkGray, 1, 1, 1, setHeight);
                g.DrawLine(OnePxVDarkGray, 0, setHeight - 1, setWidth - 2, setHeight - 1);
                g.DrawLine(OnePxVDarkGray, 0, setHeight - 2, setWidth - 3, setHeight - 2);

                g.DrawString(ip, font, Brushes.Black, 4, 6);
                g.DrawString(userpass, font, Brushes.Black, 4, 6 + (int)_ipSize.Height);
            }
            if(style == ipStyle.basic)
            {
                canvas = new Bitmap(setWidth, setHeight);
                g = Graphics.FromImage(canvas);

                Color midGray = Color.FromArgb(128, 128, 128);
                SolidBrush mGrayBrush = new SolidBrush(midGray);
                g.FillRectangle(mGrayBrush, 0, 0, setWidth, setHeight);

                g.DrawString(ip, font, Brushes.Black, 4, 6);
                g.DrawString(userpass, font, Brushes.Black, 4, 6 + (int)_ipSize.Height);
            }
            if(style == ipStyle.barBottom || style == ipStyle.barTop)
            {
                canvas = new Bitmap(imgWidth, (setHeight / 2) - 4);
                g = Graphics.FromImage(canvas);

                g.FillRectangle(Brushes.Black, 0, 0, canvas.Width, canvas.Height);
                string combo = ip + " | " + userpass;
                g.DrawString(combo, font, Brushes.White, 1, 1);
                string time = DateTime.Now.ToString();
                SizeF timeSize = g.MeasureString(time, font);
                g.DrawString(time, font, Brushes.White, canvas.Width - (int)timeSize.Width - 2, 1);
            }

            g.Dispose();
            return canvas;
        }

        public void tidy()
        {
            canvas.Dispose();
            GC.Collect();
        }
    }

    public class aspectRatio
    {
        public int width { get; set; }
        public int height { get; set; }

        public aspectRatio(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }

    public enum ipStyle : int
    {
        fancy = 0,
        basic = 1,
        barTop = 2,
        barBottom = 3
    }
}
