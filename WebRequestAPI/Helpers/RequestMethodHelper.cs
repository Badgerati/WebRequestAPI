using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebRequestAPI.Requests;
using WebRequestAPI.Handlers;

namespace WebRequestAPI.Helpers
{
    public abstract class RequestMethodHelper
    {
        public static Request.Methods Parse(string method)
        {
            string m = method.ToUpper();

            if (m.Equals("GET"))
            {
                return Request.Methods.GET;
            }
            else if (m.Equals("POST"))
            {
                return Request.Methods.POST;
            }

            ArgumentException arg = new ArgumentException("Request method not valid.");
            ErrorHandler.Throw(arg, ErrorCode.GetCode(arg));
            throw arg;
        }
    }
}
