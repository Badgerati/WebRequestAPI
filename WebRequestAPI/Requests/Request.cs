using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using WebRequestAPI.Helpers;
using WebRequestAPI.Responses;

namespace WebRequestAPI.Requests
{
    public class Request
    {
        public enum Methods
        {
            GET,
            POST
        }


        private HttpWebRequest _Request = null;


        public Request(Methods method, string url)
        {
            _Request = (HttpWebRequest)WebRequest.Create(url);
            Method = method;
        }

        public Request(HttpWebRequest request)
        {
            _Request = request;
            Method = RequestMethodHelper.Parse(request.Method);
        }


        private Methods mMethod = Methods.GET;
        public Methods Method
        {
            get { return mMethod; }
            set { mMethod = value; _Request.Method = value.ToString(); }
        }

        public long ContentLength
        {
            get { return _Request.ContentLength; }
            set { _Request.ContentLength = value; }
        }

        public string ContentType
        {
            get { return _Request.ContentType; }
            set { _Request.ContentType = value; }
        }

        public string Accept
        {
            get { return _Request.Accept; }
            set { _Request.Accept = value; }
        }

        public int Timeout
        {
            get { return _Request.Timeout; }
            set { _Request.Timeout = value; }
        }
        
        public bool AllowWriteStreamBuffering
        {
            get { return _Request.AllowWriteStreamBuffering; }
            set { _Request.AllowWriteStreamBuffering = value; }
        }


        public void AddHeader(string name, string value)
        {
            _Request.Headers.Add(name, value);
        }

        public void RemoveHeader(string name)
        {
            _Request.Headers.Remove(name);
        }

        public void ClearHeaders()
        {
            _Request.Headers.Clear();
        }

        public WebHeaderCollection GetHeaders()
        {
            return _Request.Headers;
        }


        public Response GetResponse()
        {
            return new Response(_Request);
        }


        public RequestStream GetRequestStream()
        {
            return new RequestStream(_Request);
        }


        public HttpWebRequest GetWebRequest()
        {
            return _Request;
        }

    }
}
