using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Drawing;

namespace WebRequestAPI.Responses
{
    public class ResponseStream : IDisposable
    {
        private StreamReader _StreamReader = null;


        public ResponseStream(HttpWebResponse response)
        {
            _StreamReader = new StreamReader(response.GetResponseStream());
        }

        public ResponseStream(Response response)
        {
             _StreamReader = new StreamReader(response.GetWebResponse().GetResponseStream());
        }


        /*public string ReadToEnd()
        {
            return _StreamReader.ReadToEnd();
        }


        public Bitmap ReadImage()
        {
            return new Bitmap(_StreamReader.BaseStream);
        }*/


        public void Close()
        {
            _StreamReader.Close();
        }


        public void Dispose()
        {
            Close();
        }
    }
}
