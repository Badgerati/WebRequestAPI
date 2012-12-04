using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebRequestAPI.Requests;
using WebRequestAPI.Responses;

namespace WRAPI_Test_Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            Request request = new Request(Request.Methods.GET, "http://test.ravensoft.net/interview/initial.php");
            //Request request = new Request(null);

            string content = "";
            using (Response r = request.GetResponse())
            {
                content = r.ReadToEnd();
            }

            //string content = request.ReadToEnd();
            Console.WriteLine(content);
        }
    }
}
