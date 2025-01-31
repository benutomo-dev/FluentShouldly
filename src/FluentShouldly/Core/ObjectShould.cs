using Shouldly;

namespace FluentShouldly.Core;

[ShouldlyMethods]
public class ObjectShould<T>(T actual) : IShould<T>, INotTypeShould<T>
{
    public T Actual { get; } = actual;

    public TAssignable? BeAssignableTo<TAssignable>(string? customMessage = null) where TAssignable : notnull => Actual.ShouldBeAssignableTo<TAssignable>(customMessage);

    public void NotBeAssignableTo<TAssignable>(string? customMessage = null) where TAssignable : notnull => Actual.ShouldNotBeAssignableTo<TAssignable>(customMessage);

    public TObject? BeOfType<TObject>(string? customMessage = null) where TObject : notnull => Actual.ShouldBeOfType<TObject>(customMessage);

    public void NotBeOfType<TObject>(string? customMessage = null) where TObject : notnull => Actual.ShouldNotBeOfType<TObject>(customMessage);
}
