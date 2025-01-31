using Shouldly;
using System.Diagnostics.CodeAnalysis;

namespace FluentShouldly.Core;

[ShouldlyMethods]
public class TypeShould : IShould<Type>, ITypeShould
{
    public Type Actual { get; }

    public TypeShould([NotNull] Type actual)
    {
        Actual = actual;
    }

    public void BeDecoratedWith<TAttribute>(string? customMessage = null) where TAttribute : Attribute => Actual.ShouldBeDecoratedWith<TAttribute>(customMessage);
}
