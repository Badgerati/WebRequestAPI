using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Drawing;
using System.Xml.Linq;

namespace WebRequestAPI.Responses
{
    public class Response : IDisposable
    {
        private HttpWebResponse _Response = null;


        public Response(HttpWebResponse response)
        {
            _Response = response;
        }

        public Response(HttpWebRequest request)
        {
            _Response = (HttpWebResponse)request.GetResponse();
        }


        public HttpStatusCode StatusCode
        {
            get { return _Response.StatusCode; }
        }


        public void Close()
        {
            _Response.Close();
        }


        public string ReadToEnd()
        {
            string str = "";
            using (StreamReader sr = new StreamReader(_Response.GetResponseStream()))
            {
                str = sr.ReadToEnd();
            }
            return str;
        }


        public Bitmap ReadImage()
        {
            return new Bitmap(_Response.GetResponseStream());
        }


        public XDocument ReadXMLDocument()
        {
            XDocument doc = null;
            using (StreamReader sr = new StreamReader(_Response.GetResponseStream()))
            {
                doc = XDocument.Parse(sr.ReadToEnd(), LoadOptions.None);
            }
            return doc;
        }

        public XDocument ReadXMLDocument(LoadOptions options)
        {
            XDocument doc = null;
            using (StreamReader sr = new StreamReader(_Response.GetResponseStream()))
            {
                doc = XDocument.Parse(sr.ReadToEnd(), options);
            }
            return doc;
        }


        //public ResponseStream GetResponseStream()
        //{
        //    return new ResponseStream(_Response);
        //}


        public void Dispose()
        {
            this.Close();
        }


        public HttpWebResponse GetWebResponse()
        {
            return _Response;
        }

    }
}
