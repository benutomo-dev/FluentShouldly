using Shouldly;
using Shouldly.ShouldlyExtensionMethods;
using System.Runtime.CompilerServices;
using static FluentShouldly.Tests.ExtraAssertions;

namespace FluentShouldly.Tests;

public class EnumerableCompatibilityTests
{
    [Fact]
    public void ShouldBe1()
    {
        int[] testActual = [1, 3, 5];

        testActual.Should().Be([1, 3, 5]);

        ShouldBeSameAssertion(
            () => testActual.Should().Be([1, 5, 3]),
            () => testActual.ShouldBe([1, 5, 3])
            );
    }

    [Fact]
    public void ShouldBe2()
    {
        int[] testActual = [1, 3, 5];

        testActual.Should().Be([1, 5, 3], ignoreOrder: true);

        ShouldBeSameAssertion(
            () => testActual.Should().Be([1, 5, 3], ignoreOrder: false),
            () => testActual.ShouldBe([1, 5, 3], ignoreOrder: false)
            );
    }

    [Fact]
    public void ShouldBe3()
    {
        int[] testActual = [1, 3, 5];

        testActual.Should().Be([1, 5, 3], EqualityComparer<int>.Default, ignoreOrder: true);

        ShouldBeSameAssertion(
            () => testActual.Should().Be([1, 5, 3], EqualityComparer<int>.Default, ignoreOrder: false),
            () => testActual.ShouldBe([1, 5, 3], EqualityComparer<int>.Default, ignoreOrder: false)
            );
    }

    [Fact]
    public void ShouldBe4()
    {
        decimal[] testActual = [100, 299, 501];

        testActual.Should().Be([100, 300, 500], tolerance: 1);

        ShouldBeSameAssertion(
            () => testActual.Should().Be([100, 300, 500], tolerance: 0),
            () => testActual.ShouldBe([100, 300, 500], tolerance: 0)
            );
    }

    [Fact]
    public void ShouldBe5()
    {
        double[] testActual = [1.00, 2.99, 5.01];

        testActual.Should().Be([1.00, 3.00, 5.00], tolerance: 1);

        ShouldBeSameAssertion(
            () => testActual.Should().Be([1.00, 3.00, 5.00], tolerance: 0),
            () => testActual.ShouldBe([1.00, 3.00, 5.00], tolerance: 0)
            );
    }

    [Fact]
    public void ShouldBe6()
    {
        float[] testActual = [1.00f, 2.99f, 5.01f];

        testActual.Should().Be([1.00f, 3.00f, 5.00f], tolerance: 1);

        ShouldBeSameAssertion(
            () => testActual.Should().Be([1.00f, 3.00f, 5.00f], tolerance: 0),
            () => testActual.ShouldBe([1.00f, 3.00f, 5.00f], tolerance: 0)
            );
    }

    [Fact]
    public void ShouldBe7()
    {
        string[] testActual = ["first", "second", "third"];

        testActual.Should().Be(["First", "Second", "THIRD"], Case.Insensitive);

        ShouldBeSameAssertion(
            () => testActual.Should().Be(["First", "Second", "THIRD"], Case.Sensitive),
            () => testActual.ShouldBe(["First", "Second", "THIRD"], Shouldly.Case.Sensitive)
            );
    }

    [Fact]
    public void Contain1()
    {
        int[] testActual = [1, 3, 5];

        testActual.Should().Contain(3);

        ShouldBeSameAssertion(
            () => testActual.Should().Contain(4),
            () => testActual.ShouldContain(4)
            );
    }

    [Fact]
    public void Contain2()
    {
        int[] testActual = [1, 3, 5];

        testActual.Should().Contain(3, EqualityComparer<int>.Default);

        ShouldBeSameAssertion(
            () => testActual.Should().Contain(4, EqualityComparer<int>.Default),
            () => testActual.ShouldContain(4, EqualityComparer<int>.Default)
            );
    }

    [Fact]
    public void Contain3()
    {
        int[] testActual = [1, 3, 5];

        testActual.Should().Contain(v => v == 3);

        ShouldBeSameAssertion(
            () => testActual.Should().Contain(v => v == 4),
            () => testActual.ShouldContain(v => v == 4)
            );
    }

    [Fact]
    public void Contain4()
    {
        int[] testActual = [1, 3, 5];

        testActual.Should().Contain(v => true, expectedCount: 3);

        ShouldBeSameAssertion(
            () => testActual.Should().Contain(v => true, expectedCount: 4),
            () => testActual.ShouldContain(v => true, expectedCount: 4)
            );
    }

    [Fact]
    public void Contain5()
    {
        double[] testActual = [1.00, 2.99, 5.01];

        testActual.Should().Contain(3.00, tolerance: 1);

        ShouldBeSameAssertion(
            () => testActual.Should().Contain(3.00, tolerance: 0),
            () => testActual.ShouldContain(3.00, tolerance: 0)
            );
    }

    [Fact]
    public void Contain6()
    {
        float[] testActual = [1.00f, 2.99f, 5.01f];

        testActual.Should().Contain(3.00f, tolerance: 1);

        ShouldBeSameAssertion(
            () => testActual.Should().Contain(3.00f, tolerance: 0),
            () => testActual.ShouldContain(3.00f, tolerance: 0)
            );
    }

    [Fact]
    public void NotContain1()
    {
        int[] testActual = [1, 3, 5];

        testActual.Should().NotContain(4);

        ShouldBeSameAssertion(
            () => testActual.Should().NotContain(3),
            () => testActual.ShouldNotContain(3)
            );
    }

    [Fact]
    public void NotContain2()
    {
        int[] testActual = [1, 3, 5];

        testActual.Should().NotContain(4, EqualityComparer<int>.Default);

        ShouldBeSameAssertion(
            () => testActual.Should().NotContain(3, EqualityComparer<int>.Default),
            () => testActual.ShouldNotContain(3, EqualityComparer<int>.Default)
            );
    }

    [Fact]
    public void NotAllBe1()
    {
        int[] testActual = [1, 3, 5];

        testActual.Should().AllBe(v => true);

        ShouldBeSameAssertion(
            () => testActual.Should().AllBe(v => v == 1),
            () => testActual.ShouldAllBe(v => v == 1)
            );
    }
}
