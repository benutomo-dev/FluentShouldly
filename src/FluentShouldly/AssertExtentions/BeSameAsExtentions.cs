using FluentShouldly.Core;
using Shouldly;

#pragma warning disable IDE0130 // Namespace がフォルダー構造と一致しません
namespace FluentShouldly;

[ShouldlyMethods]
public static class BeSameAsExtentions
{
    public static void BeSameAs<T>(this IShould<T> should, T? expected, string? customMessage = null) where T : class => should.Actual.ShouldBeSameAs(expected, customMessage);

    public static void NotBeSameAs<T>(this IShould<T> should, T? expected, string? customMessage = null) where T : class => should.Actual.ShouldNotBeSameAs(expected, customMessage);
}
