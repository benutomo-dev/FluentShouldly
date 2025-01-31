using Shouldly;

namespace FluentShouldly.Tests;

public static class ExtraAssertions
{
    public static void ShouldBeSameAssertion(Action fluentShouldly, Action shouldly)
    {
        var fluentShuldlyAssertion = Shouldly.Should.Throw<ShouldAssertException>(fluentShouldly);
        var originalShuldlyAssertion = Shouldly.Should.Throw<ShouldAssertException>(shouldly);

        fluentShuldlyAssertion.Message.Replace(".Should()", "").ShouldBe(originalShuldlyAssertion.Message);
    }
}
