using Shouldly;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace FluentShouldly.Tests;

public static class ExtraAssertions
{
    public static void ShouldBeSameAssertion(Action fluentShouldly, Action shouldly)
    {
        var fluentShuldlyAssertion = Run(fluentShouldly);

        fluentShuldlyAssertion.ShouldNotBeNull();

        var originalShuldlyAssertion = Run(shouldly);

        originalShuldlyAssertion.ShouldNotBeNull();

        fluentShuldlyAssertion.Message.Replace(".Should()", "").ShouldBe(originalShuldlyAssertion.Message);
    }

    public static async Task ShouldBeSameAssertionAsync(Func<Task> fluentShouldly, Func<Task> shouldly)
    {
        var fluentShuldlyAssertion = await RunAsync(fluentShouldly).ConfigureAwait(false);

        fluentShuldlyAssertion.ShouldNotBeNull();

        var originalShuldlyAssertion = await RunAsync(shouldly).ConfigureAwait(false);

        originalShuldlyAssertion.ShouldNotBeNull();

        fluentShuldlyAssertion.Message.Replace(".Should()", "").ShouldBe(originalShuldlyAssertion.Message);
    }

    public static ShouldAssertException? Run(Action action, [CallerArgumentExpression(nameof(action))] string actionExp = "")
    {
        try
        {
            action();
            return null;
        }
        catch (ShouldAssertException ex)
        {
            return ex;
        }
    }

    public static async Task<ShouldAssertException?> RunAsync(Func<Task> action, [CallerArgumentExpression(nameof(action))] string actionExp = "")
    {
        try
        {
            await action().ConfigureAwait(false);
            return null;
        }
        catch (ShouldAssertException ex)
        {
            return ex;
        }
    }
}
