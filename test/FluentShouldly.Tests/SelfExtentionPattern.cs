using FluentShouldly.Core;
using Shouldly;
using System.Numerics;

namespace FluentShouldly.Tests;

public class SelfExtentionPattern
{
    [Fact]
    public void SelfDefinedShouldAssertion()
    {
        var actualException = Should.Throw<ShouldAssertException>(() =>
            int.Parse("3").Should().BeEven()
            );


        actualException.Message.ShouldBe("""
            int.Parse("3").Should()
                should be even but 3 is odd
            """);
    }
}

[ShouldlyMethods]
file static class SelfExntesions
{
    public static void BeEven<T>(this IShould<T> should, string? customMessage = null) where T : INumberBase<T>
    {
        if (!T.IsEvenInteger(should.Actual))
        {
            var context = new ShouldlyAssertionContext(nameof(BeEven), actual: should.Actual);

            var message = $"""
                {context.CodePart}
                    should be even but {should.Actual} is odd
                """;

            throw new ShouldAssertException(message);
        }
    }
}
