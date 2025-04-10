using System;
using System.Linq.Expressions;

namespace OdooSharp.Extensions
{
    public class OdooExpressionParser
    {
        public object Parse(Expression expression)
        {
            return ParseInternal(expression);
        }

        private object ParseInternal(Expression expr)
        {
            return expr switch
            {
                BinaryExpression binary => ParseBinary(binary),
                MethodCallExpression method => ParseMethodCall(method),
                _ => throw new NotSupportedException($"Unsupported expression type: {expr.NodeType}")
            };
        }

        private object ParseBinary(BinaryExpression binary)
        {
            // Kombinierte Filter (AND/OR)
            if (binary.NodeType is ExpressionType.AndAlso || binary.NodeType is ExpressionType.OrElse)
            {
                var left = ParseInternal(binary.Left);
                var right = ParseInternal(binary.Right);
                var logical = binary.NodeType == ExpressionType.AndAlso ? "&" : "|";
                return new object[] { logical, left, right };
            }

            // Einfache Bedingungen wie a == b
            var memberExpr = GetMemberExpression(binary.Left);
            var fieldName = ExpressionHelper.GetPropertyName(memberExpr);
            //var odooField = ExpressionHelper.ToOdooFieldName(fieldName);
            var odooField = ExpressionHelper.GetOdooFieldName(memberExpr);

            var value = GetValue(binary.Right);

            var op = binary.NodeType switch
            {
                ExpressionType.Equal => "=",
                ExpressionType.NotEqual => "!=",
                ExpressionType.GreaterThan => ">",
                ExpressionType.GreaterThanOrEqual => ">=",
                ExpressionType.LessThan => "<",
                ExpressionType.LessThanOrEqual => "<=",
                _ => throw new NotSupportedException($"Operator {binary.NodeType} not supported")
            };

            return new object[] { odooField, op, value };
        }

        private object ParseMethodCall(MethodCallExpression method)
        {
            // z. B. p.Email.Contains("gmail.com")
            if (method.Method.Name == nameof(string.Contains) && method.Object != null)
            {
                var field = GetMemberExpression(method.Object);
                //var fieldName = ExpressionHelper.ToOdooFieldName(ExpressionHelper.GetPropertyName(field));
                var fieldName = ExpressionHelper.GetOdooFieldName(method);
                var value = GetValue(method.Arguments[0]);
                return new object[] { fieldName, "ilike", value };
            }

            if (method.Method.Name == nameof(string.StartsWith) && method.Object != null)
            {
                var field = GetMemberExpression(method.Object);
                //var fieldName = ExpressionHelper.ToOdooFieldName(ExpressionHelper.GetPropertyName(field));
                var fieldName = ExpressionHelper.GetOdooFieldName(method);
                var value = GetValue(method.Arguments[0]);
                return new object[] { fieldName, "ilike", value };
            }

            if (method.Method.Name == nameof(string.EndsWith) && method.Object != null)
            {
                var field = GetMemberExpression(method.Object);
                //var fieldName = ExpressionHelper.ToOdooFieldName(ExpressionHelper.GetPropertyName(field));
                var fieldName = ExpressionHelper.GetOdooFieldName(method);
                var value = GetValue(method.Arguments[0]);
                return new object[] { fieldName, "ilike", value };
            }

            throw new NotSupportedException($"Unsupported method: {method.Method.Name}");
        }

        private MemberExpression GetMemberExpression(Expression expr)
        {
            return expr switch
            {
                MemberExpression member => member,
                UnaryExpression unary when unary.Operand is MemberExpression member => member,
                _ => throw new InvalidOperationException("Expected MemberExpression")
            };
        }

        private object GetValue(Expression expr)
        {
            var lambda = Expression.Lambda(expr);
            var compiled = lambda.Compile();
            return compiled.DynamicInvoke();
        }
    }
}
