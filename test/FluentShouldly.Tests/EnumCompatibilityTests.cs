using Shouldly;
using Shouldly.ShouldlyExtensionMethods;
using System.Runtime.CompilerServices;
using static FluentShouldly.Tests.ExtraAssertions;

namespace FluentShouldly.Tests;

public class EnumCompatibilityTests
{
    [Fact]
    public void ShouldBe1()
    {
        var testActual = MethodImplOptions.Unmanaged;

        ShouldBeSameAssertion(
            () => testActual.Should().Be(MethodImplOptions.NoInlining),
            () => testActual.ShouldBe(MethodImplOptions.NoInlining)
            );
    }

    [Fact]
    public void ShouldNotBe1()
    {
        var testActual = MethodImplOptions.Unmanaged;

        ShouldBeSameAssertion(
            () => testActual.Should().NotBe(MethodImplOptions.Unmanaged),
            () => testActual.ShouldNotBe(MethodImplOptions.Unmanaged)
            );
    }

    [Fact]
    public void ShouldHaveFlag1()
    {
        var testActual = MethodImplOptions.Unmanaged;

        ShouldBeSameAssertion(
            () => testActual.Should().HaveFlag(MethodImplOptions.NoInlining),
            () => testActual.ShouldHaveFlag(MethodImplOptions.NoInlining)
            );
    }

    [Fact]
    public void ShouldNotHaveFlag1()
    {
        var testActual = MethodImplOptions.Unmanaged;

        ShouldBeSameAssertion(
            () => testActual.Should().NotHaveFlag(MethodImplOptions.Unmanaged),
            () => testActual.ShouldNotHaveFlag(MethodImplOptions.Unmanaged)
            );
    }
}
