using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;

namespace WebRequestAPI.Requests
{
    public class RequestStream : IDisposable
    {
        private Stream _Stream = null;


        public RequestStream(HttpWebRequest request)
        {
            _Stream = request.GetRequestStream();
        }

        public RequestStream(Request request)
        {
            _Stream = request.GetWebRequest().GetRequestStream();
        }


        public void Write(byte[] buffer, int offset, int count)
        {
            _Stream.Write(buffer, offset, count);
        }


        public void Close()
        {
            _Stream.Close();
        }


        public void Dispose()
        {
            Close();
        }
    }
}
