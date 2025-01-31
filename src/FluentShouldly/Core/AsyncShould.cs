using Shouldly;

namespace FluentShouldly.Core;

[ShouldlyMethods]
public class AsyncShould : ObjectShould<Func<Task>>
{
    public AsyncShould(Func<Task> actual) : base(actual) { }

    public async Task<TException> ThrowAsync<TException>(string? customMessage = null) where TException : Exception => await Actual.ShouldThrowAsync<TException>(customMessage).ConfigureAwait(false);
}
