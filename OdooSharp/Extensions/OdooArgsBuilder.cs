using OdooSharp.Client;
using System;
using System.Collections.Generic;

namespace OdooSharp.Extensions
{
    public static class OdooArgsBuilder
    {
        public static object[] FromExecuteKw(OdooExecuteKwArgs args)
        {
            var finalArgs = new List<object>
        {
            args.Db,
            args.UserId,
            args.Password,
            args.Model,
            args.Method,
            args.MethodArgs ?? Array.Empty<object>()
        };

            if (args.Kwargs != null)
            {
                finalArgs.Add(args.Kwargs);
            }

            return finalArgs.ToArray();
        }
    }
}
