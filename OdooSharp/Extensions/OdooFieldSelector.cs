using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OdooSharp.Extensions
{
    public static class OdooFieldSelector
    {
        public static string[]? ExtractFields(Expression expression)
        {
            var visitor = new FieldVisitor();
            visitor.Visit(expression);

            return visitor.Fields.Count > 0 ? visitor.Fields.ToArray() : null; // null = alle Felder laden
        }

        private class FieldVisitor : ExpressionVisitor
        {
            public HashSet<string> Fields { get; } = new HashSet<string>();

            protected override Expression VisitMember(MemberExpression node)
            {
                Fields.Add(ExpressionHelper.GetOdooFieldName(node));
                //Fields.Add(ExpressionHelper.ToOdooFieldName(node.Member.Name));
                return base.VisitMember(node);
            }

            protected override Expression VisitNew(NewExpression node)
            {
                foreach (var arg in node.Arguments)
                {
                    Visit(arg);
                }

                return base.VisitNew(node);
            }
        }
    }
}
