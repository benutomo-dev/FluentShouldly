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
    internal sealed class OverloadResolutionPriorityAttribute : Attribute
    {
        public OverloadResolutionPriorityAttribute(int priority)
        {
            Priority = priority;
        }

        public int Priority { get; }
    }
#endif
}
