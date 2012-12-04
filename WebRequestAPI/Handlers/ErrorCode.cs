using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace WebRequestAPI.Handlers
{
    public abstract class ErrorCode
    {
        public static int GetCode(Exception ex)
        {
            if (ex is WebException) return 1001;
            if (ex is NotSupportedException) return 1002;
            if (ex is ArgumentException) return 1003;
            if (ex is NullReferenceException) return 1004;
            return 1000;
        }
    }
}
