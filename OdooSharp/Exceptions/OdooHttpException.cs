using System;
using System.Net;

namespace OdooSharp.Exceptions
{
    public class OdooHttpException : Exception
    {
        public HttpStatusCode StatusCode { get; }
        public string ResponseBody { get; }

        public OdooHttpException(HttpStatusCode statusCode, string responseBody)
            : base($"Odoo HTTP request failed with status {(int)statusCode} ({statusCode}).")
        {
            StatusCode = statusCode;
            ResponseBody = responseBody;
        }
    }
}
