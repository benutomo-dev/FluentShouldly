using Shouldly;

namespace FluentShouldly.Core;

[ShouldlyMethods]
public class ActionShould : ObjectShould<Action>
{
    public ActionShould(Action actual) : base(actual) { }

    public TException Throw<TException>(string? customMessage = null) where TException : Exception => Actual.ShouldThrow<TException>(customMessage);
}
