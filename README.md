# FluentShouldly

FluentAssertions-style syntax support for [Shouldly](https://docs.shouldly.org/). This package provides a fluent interface for Shouldly assertions, allowing you to write assertions like `actual.Should().Be(expected)` while maintaining Shouldly's clear error messages. Designed to keep IntelliSense clean by separating the assertion methods into a dedicated namespace.

## How to use

Add the following package reference to csproj in the test project.

ℹ️ There is no need to explicitly add a "Shouldly" package reference. Adding it may cause extended methods such as "ShouldXxx()" to appear in the completion candidates for any object.

```xml
<ItemGroup>
  <PackageReference Include="Benutomo.FluentShouldly" Version="Xxxx" /> <!-- Xxxx is the latest published version -->

  <!-- There is no need to explicitly add a "Shouldly" package reference. -->
  <!-- <PackageReference Include="Shouldly" Version="Xxxx" /> -->
</ItemGroup>
```

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
