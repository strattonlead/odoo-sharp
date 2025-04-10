using System.Collections.Generic;

namespace OdooSharp.Client
{
    public class OdooExecuteKwArgs
    {
        public string Db { get; set; }
        public int UserId { get; set; }
        public string Password { get; set; }
        public string Model { get; set; }
        public string Method { get; set; }
        public object[] MethodArgs { get; set; }
        public Dictionary<string, object> Kwargs { get; set; }
    }
}
