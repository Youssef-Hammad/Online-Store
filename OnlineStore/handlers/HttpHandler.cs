using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    class HttpHandler
    {
        private string baseURL;
        private string entity;
        private string secString;
        private string param;

        public HttpHandler(string tmpEntity = "", string tmpParam = "")
        {
            baseURL = "http://okboomer-api.somee.com/APIDIR/api";
            entity = tmpEntity;
            secString = "CWyNnomeXehvyucs";
            param = tmpParam;
        }
        override
        public string ToString()
        {
            return baseURL + "/" + entity + "/" + secString;
        }

        public string POST()
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(this.ToString());
            Console.WriteLine(param);
            var Data = Encoding.ASCII.GetBytes(param);
            req.Method = "POST";
            req.ContentType = "application/json";
            req.ContentLength = Data.Length;

            using (var stream = req.GetRequestStream())
            {
                stream.Write(Data, 0, Data.Length);
            }

            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            string resString = new StreamReader(res.GetResponseStream()).ReadToEnd();
            return resString;
        }
        public string GET()
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(ToString());
            req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            using(HttpWebResponse response=(HttpWebResponse)req.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
