# FluentShouldly

FluentAssertions-style syntax support for [Shouldly](https://docs.shouldly.org/). This package provides a fluent interface for Shouldly assertions, allowing you to write assertions like `actual.Should().Be(expected)` while maintaining Shouldly's clear error messages. Designed to keep IntelliSense clean by separating the assertion methods into a dedicated namespace.

## Sample code

```csharp
using FluentShouldly;

namespace TestExamples;

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
```
