//using OdooSharp.Client;
//using OdooSharp.Extensions;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;

//namespace OdooSharp.Queries
//{
//    public class OdooQueryProvider : IQueryProvider
//    {
//        private readonly IOdooClient _client;

//        public OdooQueryProvider(IOdooClient client) => _client = client;

//        public IQueryable CreateQuery(Expression expression) =>
//            (IQueryable)Activator.CreateInstance(typeof(OdooQuery<>).MakeGenericType(expression.Type.GetGenericArguments()[0]), _client, expression);

//        public IQueryable<TElement> CreateQuery<TElement>(Expression expression) =>
//            new OdooQuery<TElement>(_client, expression);

//        public object Execute(Expression expression) =>
//            Execute<object>(expression);

//        public TResult Execute<TResult>(Expression expression)
//        {
//            var parser = new OdooExpressionParser();
//            var domain = parser.Parse(expression);

//            var fields = OdooFieldSelector.ExtractFields(expression);
//            var limit = OdooLimitExtractor.ExtractLimit(expression);

//            var resultType = typeof(TResult);
//            // 1. Liste: .ToList(), .AsEnumerable()
//            if (resultType.IsGenericType && resultType.GetGenericTypeDefinition() == typeof(List<>))
//            {

//            }

//            // 2. Count()
//            if (resultType == typeof(int))
//            {

//            }

//            // 3. LongCount()
//            if (resultType == typeof(long))
//            {

//            }

//            // 4. Boolean: .Any()
//            if (resultType == typeof(bool))
//            {

//            }

//            // 5. Einzelwert: FirstOrDefault(), SingleOrDefault()

//            var result = _client.SearchReadAsync<TResult>(
//                domain: (object[])domain,
//                fields: fields,
//                limit: limit ?? 100
//            ).Result;

//            return result;
//        }
//    }

//}
