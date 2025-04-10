using System.Linq.Expressions;

namespace OdooSharp.Extensions
{
    public static class OdooLimitExtractor
    {
        public static int? ExtractLimit(Expression expression)
        {
            var visitor = new LimitVisitor();
            visitor.Visit(expression);
            return visitor.Limit;
        }

        private class LimitVisitor : ExpressionVisitor
        {
            public int? Limit { get; private set; }

            protected override Expression VisitMethodCall(MethodCallExpression node)
            {
                if (node.Method.Name == "Take" && node.Arguments.Count == 2)
                {
                    if (node.Arguments[1] is ConstantExpression constant && constant.Type == typeof(int))
                    {
                        Limit = (int)constant.Value;
                    }
                }

                return base.VisitMethodCall(node);
            }
        }
    }
}
