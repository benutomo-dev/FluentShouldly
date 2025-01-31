using FluentShouldly.Core;
using Shouldly;

#pragma warning disable IDE0130 // Namespace がフォルダー構造と一致しません
namespace FluentShouldly;

[ShouldlyMethods]
public static class BooleanShouldExtentions
{
    public static void BeTrue(this IShould<bool> should, string? customMessage = null) => should.Actual.ShouldBeTrue(customMessage);

    public static void BeFalse(this IShould<bool> should, string? customMessage = null) => should.Actual.ShouldBeFalse(customMessage);
}
