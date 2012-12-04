using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WebRequestAPI.Helpers
{
    public abstract class FileHelper
    {
        public static string ReadFile(string location)
        {
            string file = "";
            using (StreamReader sr = new StreamReader(location))
            {
                file = sr.ReadToEnd();
            }
            return file;
        }
    }
}
