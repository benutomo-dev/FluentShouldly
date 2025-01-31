using Shouldly;

namespace FluentShouldly;

[ShouldlyMethods]
public static class Should
{
    public static TException Throw<TException>(Action action, string? customMessage = null) where TException : Exception => Shouldly.Should.Throw<TException>(action, customMessage);

    public static Exception Throw(Action action, Type exceptionType, string? customMessage = null) => Shouldly.Should.Throw(action, exceptionType, customMessage);

    public static void NotThrow(Action action, string? customMessage = null) => Shouldly.Should.NotThrow(action, customMessage);

    public static async Task<TException> ThrowAsync<TException>(Task task, string? customMessage = null) where TException : Exception => await Shouldly.Should.ThrowAsync<TException>(task, customMessage).ConfigureAwait(false);

    public static async Task<Exception> ThrowAsync(Task task, Type exceptionType, string? customMessage = null) => await Shouldly.Should.ThrowAsync(task, exceptionType, customMessage).ConfigureAwait(false);

    public static async Task<TException> ThrowAsync<TException>(Func<Task> asyncAction, string? customMessage = null) where TException : Exception => await Shouldly.Should.ThrowAsync<TException>(asyncAction, customMessage).ConfigureAwait(false);

    public static async Task<Exception> ThrowAsync(Func<Task> asyncAction, Type exceptionType, string? customMessage = null) => await Shouldly.Should.ThrowAsync(asyncAction, exceptionType, customMessage).ConfigureAwait(false);

    public static async Task NotThrowAsync(Task task, string? customMessage = null) => await Shouldly.Should.NotThrowAsync(task, customMessage).ConfigureAwait(false);

    public static async Task NotThrowAsync(Func<Task> asyncAction, string? customMessage = null) => await Shouldly.Should.NotThrowAsync(asyncAction, customMessage).ConfigureAwait(false);
}
