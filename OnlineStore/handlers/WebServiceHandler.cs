using System;
using System.Text;
using System.Net;
using System.IO;

namespace OnlineStore
{
    public class WebServiceHandler
    {
        protected string baseURL;
        protected string entity;
        protected string secString;
        protected string param;

        public WebServiceHandler(string tmpEntity = "", string tmpParam = "")
        {
            baseURL = "http://okboomer-api.somee.com/APIDIR/api";
            entity = tmpEntity;
            secString = "CWyNnomeXehvyucs";
            param = tmpParam;
        }

        public HttpWebResponse POST()
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(baseURL + "/" + entity + "/" + secString);
            var Data = Encoding.ASCII.GetBytes(param);
            req.Method = "POST";
            req.ContentType = "application/json";
            req.ContentLength = Data.Length;

            using (var stream = req.GetRequestStream())
            {
                stream.Write(Data, 0, Data.Length);
            }

            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            return res;
        }

        public HttpWebResponse GET()
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(baseURL + "/" + entity + "/" + secString + "/" + param);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            return res;
        }

        public string GetResponseBody(HttpWebResponse responseMsg)
        {
            return new StreamReader(responseMsg.GetResponseStream()).ReadToEnd();
        }
    }
}
