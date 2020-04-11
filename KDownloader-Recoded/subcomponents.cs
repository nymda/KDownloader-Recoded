using System;
using System.Collections.Generic;
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
}
