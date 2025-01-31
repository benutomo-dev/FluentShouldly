using Shouldly;

namespace FluentShouldly.Core;

[ShouldlyMethods]
public class ActionShould(Action actual) : ObjectShould<Action>(actual)
{
    public TException Throw<TException>(string? customMessage = null) where TException : Exception => Actual.ShouldThrow<TException>(customMessage);
}
