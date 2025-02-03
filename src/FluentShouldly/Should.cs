using Shouldly;
using System.Runtime.CompilerServices;

namespace FluentShouldly;

[ShouldlyMethods]
public static class Should
{
    public static TException Throw<TException>(Action action, string? customMessage = null) where TException : Exception => Shouldly.Should.Throw<TException>(action, customMessage);

    public static TException Throw<TException>(Func<object?> action, string? customMessage = null) where TException : Exception => Shouldly.Should.Throw<TException>(action, customMessage);

    public static Exception Throw(Action action, Type exceptionType, string? customMessage = null) => Shouldly.Should.Throw(action, exceptionType, customMessage);

    public static Exception Throw<T>(Func<T> action, Type exceptionType, string? customMessage = null) => Shouldly.Should.Throw(() => _ = action(), exceptionType, customMessage);

    public static void NotThrow(Action action, string? customMessage = null) => Shouldly.Should.NotThrow(action, customMessage);

    public static T NotThrow<T>(Func<T> action, string? customMessage = null) => Shouldly.Should.NotThrow(action, customMessage);

    public static async Task<TException> ThrowAsync<TException>(Func<Task> asyncAction, string? customMessage = null, [CallerArgumentExpression(nameof(asyncAction))] string? asyncActionExp = null) where TException : Exception
        => (TException)(await ThrowCoreAsync(asyncAction, typeof(TException), customMessage, asyncActionExp).ConfigureAwait(false));

    public static async Task<Exception> ThrowAsync(Func<Task> asyncAction, Type exceptionType, string? customMessage = null, [CallerArgumentExpression(nameof(asyncAction))] string? asyncActionExp = null)
        => await ThrowCoreAsync(asyncAction, exceptionType, customMessage, asyncActionExp).ConfigureAwait(false);

    public static async Task<Exception> ThrowCoreAsync(Func<Task> asyncAction, Type exceptionType, string? customMessage, string? asyncActionExp)
    {
        // 非同期版の例外検証はオリジナルのShouldlyの実装メソッドを呼び出すと検証対象の式の情報が失われてしまうので
        // ほぼ同じメッセージを出力する検証を自前で実装

        try
        {
            await asyncAction().ConfigureAwait(false);
        }
        catch (ShouldAssertException)
        {
            throw;
        }
        catch (Exception ex) when (exceptionType.IsAssignableFrom(ex.GetType()))
        {
            return ex;
        }
        catch (Exception ex)
        {
            throw new ShouldAssertException(buildOriginalLikeMessage(exceptionType, asyncActionExp ?? "Task", ex));
        }

        throw new ShouldAssertException(buildOriginalLikeMessage(exceptionType, asyncActionExp ?? "Task", ex: null));

        static string buildOriginalLikeMessage(Type exceptionType, string asyncActionExp, Exception? ex)
        {
            if (ex is null)
            {
                return $$"""
                `{{asyncActionExp}}`
                    should throw
                {{exceptionType.FullName}}
                    but did not
                """;
            }

            if (ex is AggregateException aggregateEx)
            {
                aggregateEx = aggregateEx.Flatten();

                if (aggregateEx.InnerExceptions.Count == 1)
                    ex = aggregateEx.InnerExceptions[0];
            }

            return $$"""
                `{{asyncActionExp}}`
                    should throw
                {{exceptionType.FullName}}
                    but threw
                {{ex.GetType().FullName}}
                    with message
                "{{ex.Message}}"
                """;
        }
    }

    public static async Task NotThrowAsync(Func<Task> asyncAction, string? customMessage = null, [CallerArgumentExpression(nameof(asyncAction))] string? asyncActionExp = null)
    {
        // 非同期版の例外検証はオリジナルのShouldlyの実装メソッドを呼び出すと検証対象の式の情報が失われてしまうので
        // ほぼ同じメッセージを出力する検証を自前で実装

        try
        {
            await asyncAction().ConfigureAwait(false);
        }
        catch (ShouldAssertException)
        {
            throw;
        }
        catch (Exception ex)
        {
            throw new ShouldAssertException(buildOriginalLikeMessage(asyncActionExp ?? "Task", ex));
        }

        static string buildOriginalLikeMessage(string asyncActionExp, Exception ex)
        {
            if (ex is AggregateException aggregateEx)
            {
                aggregateEx = aggregateEx.Flatten();

                if (aggregateEx.InnerExceptions.Count == 1)
                    ex = aggregateEx.InnerExceptions[0];
            }

            return $$"""
                `{{asyncActionExp}}`
                    should not throw but threw
                {{ex.GetType().FullName}}
                    with message
                "{{ex.Message}}"
                """;
        }
    }
}
