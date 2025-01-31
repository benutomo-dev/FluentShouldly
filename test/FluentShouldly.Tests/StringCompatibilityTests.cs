using Shouldly;

using static FluentShouldly.Tests.ExtraAssertions;

namespace FluentShouldly.Tests;

public class StringCompatibilityTests
{
    [Fact]
    public void ShouldBe1()
    {
        string testActual = "asdf";

        ShouldBeSameAssertion(
            () => testActual.Should().Be("1234"),
            () => testActual.ShouldBe("1234")
            );
    }

    [Fact]
    public void ShouldBe2()
    {
        string testActual = "asdf";

        ShouldBeSameAssertion(
            () => testActual.Should().Be("1234", StringCompareShould.IgnoreCase),
            () => testActual.ShouldBe("1234", Shouldly.StringCompareShould.IgnoreCase)
            );
    }

    [Fact]
    public void ShouldBe3()
    {
        string testActual = "asdf";

        ShouldBeSameAssertion(
            () => testActual.Should().Be("1234", "Costum message.", StringCompareShould.IgnoreCase),
            () => testActual.ShouldBe("1234", "Costum message.", Shouldly.StringCompareShould.IgnoreCase)
            );
    }

    [Fact]
    public void ShouldNotBe1()
    {
        string testActual = "asdf";

        ShouldBeSameAssertion(
            () => testActual.Should().NotBe("asdf"),
            () => testActual.ShouldNotBe("asdf")
            );
    }
}
