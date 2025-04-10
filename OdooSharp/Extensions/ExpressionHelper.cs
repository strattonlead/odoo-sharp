using OdooSharp.Configuration;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace OdooSharp.Extensions
{
    public static class ExpressionHelper
    {
        public static string GetPropertyName(Expression expression)
        {
            return expression switch
            {
                MemberExpression member => member.Member.Name,
                UnaryExpression unary when unary.Operand is MemberExpression member => member.Member.Name,
                LambdaExpression lambda => GetPropertyName(lambda.Body),
                _ => throw new InvalidOperationException("Unsupported expression type for property access.")
            };
        }

        public static string GetPropertyName<T, TValue>(Expression<Func<T, TValue>> expression)
        {
            return GetPropertyName(expression.Body);
        }

        public static string GetOdooFieldName(Expression expression)
        {
            return expression switch
            {
                MemberExpression member => member.Member.Name,
                UnaryExpression unary when unary.Operand is MemberExpression member => member.Member.Name,
                MethodCallExpression method when method.Object is MemberExpression member => GetOdooFieldName(member),
                LambdaExpression lambda => GetOdooFieldName(lambda.Body),
                _ => throw new InvalidOperationException("Unsupported expression type for property access.")
            };
        }

        public static string GetOdooFieldName(MemberExpression member)
        {
            var attr = member.Member.GetCustomAttribute<OdooFieldAttribute>();
            return attr?.FieldName ?? ToOdooFieldName(member.Member.Name);
        }

        public static string ToOdooFieldName(string csharpProperty)
        {

            return /*"x_" +*/ string.Concat(
                csharpProperty.Select((c, i) =>
                    i > 0 && char.IsUpper(c) ? "_" + char.ToLower(c) : char.ToLower(c).ToString()
                )
            );
        }
    }
}
