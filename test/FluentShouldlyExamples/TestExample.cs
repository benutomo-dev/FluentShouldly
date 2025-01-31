namespace FluentShouldly.Tests;

public class TestExample
{
    [Fact]
    public void Test()
    {
        var actual = "abcd";

        actual.Should().Be("abcd");

        actual.ShouldSatisfyAllConditions(
            actual => actual.Should().StartWith("ab"),
            actual => actual.Should().Contain("bc"),
            actual => actual.Should().NotEndWith(".")
            );

        var ex = Should.Throw<InvalidOperationException>(() => throw new InvalidOperationException("This is dummy."));
        ex.Message.Should().Be("this is dummy.", StringCompareShould.IgnoreCase);
    }
}
