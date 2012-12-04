using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebRequestAPI.Helpers;
using WebRequestAPI.Utils;

namespace WRAPI_Test_Console.Tests.Helpers
{
    class FileHelper_Tests
    {

        public void ReadInFile_Successful()
        {
            string txt = FileHelper.ReadFile("../../TextFile.txt");
            Assert.IsTrue(txt == "Test");
        }

    }
}
