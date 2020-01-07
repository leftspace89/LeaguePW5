using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeaguePW5
{
    public class LCU
    {
        public string address { get; set; }
        public int port { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string protocol { get; set; }
        public string process_name { get; set; }
        public int process_id { get; set; }
        public string baseURL => string.Format("{0}://{1}:{2}", this.protocol, this.address, this.port);
        public LCU()
        {
            Process[] process = Process.GetProcessesByName("LeagueClientUx");
            if (process.Length != 0)
            {
                string lockFile;
                using (FileStream stream = File.Open(Path.Combine(Path.GetDirectoryName(process[0].MainModule.FileName), "lockfile"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    lockFile = new StreamReader(stream).ReadToEnd();
                }
                string[] parameters = lockFile.Split(new string[] { ":" }, StringSplitOptions.None);
                this.username = "riot";
                this.address = "127.0.0.1";
                this.process_name = parameters[0];
                this.process_id = Convert.ToInt32(parameters[1]);
                this.port = Convert.ToInt32(parameters[2]);
                this.password = parameters[3];
                this.protocol = parameters[4];

            }
        }
        public HttpClient http_client
        {
            get
            {
                HttpClientHandler httpClientHandler = new HttpClientHandler();
                httpClientHandler.ClientCertificateOptions = ClientCertificateOption.Manual;
                httpClientHandler.ServerCertificateCustomValidationCallback = ((HttpRequestMessage httpRequestMessage, X509Certificate2 cert, X509Chain cetChain, SslPolicyErrors policyErrors) => true);
                return new HttpClient(httpClientHandler)
                {
                    DefaultRequestHeaders =
                    {
                        Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes("riot:" + this.password)))
                    }
                };
            }
            set
            {
            }
        }



    }
}
