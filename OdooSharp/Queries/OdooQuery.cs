using OdooSharp.Client;
using OdooSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OdooSharp.Queries
{
    public class OdooQuery<T>
    {
        private readonly List<object[]> _domain = new List<object[]>();
        private int? _limit;
        private int? _skip;
        private string[] _fields;
        private IOdooClient _client;

        public OdooQuery(IOdooClient client)
        {
            _client = client;
        }


        public OdooQuery<T> Where(Expression<Func<T, bool>> predicate)
        {
            var parser = new OdooExpressionParser();
            var domain = parser.Parse(predicate.Body);
            _domain.Add(new[] { domain });
            return this;
        }

        public OdooQuery<T> Take(int n)
        {
            _limit = n;
            return this;
        }

        public OdooQuery<T> Skip(int n)
        {
            _skip = n;
            return this;
        }

        public OdooQuery<T> Select(params Expression<Func<T, object>>[] selectors)
        {
            _fields = selectors
                .Select(sel => ExpressionHelper.GetPropertyName(sel.Body))
                .ToArray();
            return this;
        }

        public async Task<List<T>> ToListAsync()
        {
            var res = await _client.SearchReadAsync<T>(_domain.ToArray().FirstOrDefault(), _fields, _limit ?? 100, _skip ?? 0);
            return res.Result ?? new List<T>();
        }

        public async Task<T> FirstOrDefault() => (await ToListAsync()).FirstOrDefault();

        //#region IQueryable

        //public Type ElementType => typeof(T);
        //public Expression Expression { get; }
        //public IQueryProvider Provider { get; }

        //public IEnumerator<T> GetEnumerator() => Provider.Execute<IEnumerable<T>>(Expression).GetEnumerator();
        //IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        //#endregion
    }

    public static class OdooQueryExtensions
    {
        public static OdooQuery<T> Query<T>(this IOdooClient client) => new OdooQuery<T>(client);
    }
}
