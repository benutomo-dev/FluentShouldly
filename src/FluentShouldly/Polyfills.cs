#pragma warning disable IDE0130 // Namespace がフォルダー構造と一致しません

namespace System.Diagnostics.CodeAnalysis
{
#if !NETCOREAPP3_0_OR_GREATER
    internal sealed class NotNullAttribute : Attribute { }
#endif
}

namespace System.Runtime.CompilerServices
{
#if !NET9_0_OR_GREATER
    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    internal sealed class OverloadResolutionPriorityAttribute(int priority) : Attribute
    {
        public int Priority { get; } = priority;
    }
#endif

#if !NET8_0_OR_GREATER
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
    internal sealed class CallerArgumentExpressionAttribute : Attribute
    {
        public string ParameterName { get; }

        public CallerArgumentExpressionAttribute(string parameterName)
        {
            ParameterName = parameterName;
        }
    }
#endif
}
