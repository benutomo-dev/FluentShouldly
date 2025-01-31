using FluentShouldly.Core;
using Shouldly;

#pragma warning disable IDE0130 // Namespace がフォルダー構造と一致しません
namespace FluentShouldly;

[ShouldlyMethods]
public static class BeNullExtentions
{
    public static void BeNull<T>(this IShould<T?> should, string? customMessage = null) where T : class => should.Actual.ShouldBeNull(customMessage);

    public static void BeNull<T>(this IShould<T?> should, string? customMessage = null) where T : struct => should.Actual.ShouldBeNull(customMessage);

    public static void NotBeNull<T>(this IShould<T?> should, string? customMessage = null) where T : class => should.Actual.ShouldNotBeNull(customMessage);

    public static void NotBeNull<T>(this IShould<T?> should, string? customMessage = null) where T : struct => should.Actual.ShouldNotBeNull(customMessage);
}
