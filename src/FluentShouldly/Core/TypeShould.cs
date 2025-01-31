using Shouldly;
using System.Diagnostics.CodeAnalysis;

namespace FluentShouldly.Core;

[ShouldlyMethods]
public class TypeShould([NotNull] Type actual) : IShould<Type>, ITypeShould
{
    public Type Actual { get; } = actual;

    public void BeDecoratedWith<TAttribute>(string? customMessage = null) where TAttribute : Attribute => Actual.ShouldBeDecoratedWith<TAttribute>(customMessage);
}
