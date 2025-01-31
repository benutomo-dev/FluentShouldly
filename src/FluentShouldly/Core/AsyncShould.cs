using Shouldly;

namespace FluentShouldly.Core;

[ShouldlyMethods]
public class AsyncShould(Func<Task> actual) : ObjectShould<Func<Task>>(actual)
{
    public async Task<TException> ThrowAsync<TException>(string? customMessage = null) where TException : Exception => await Actual.ShouldThrowAsync<TException>(customMessage).ConfigureAwait(false);
}
