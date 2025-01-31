using FluentShouldly.Core;
using Shouldly;

#pragma warning disable IDE0130 // Namespace がフォルダー構造と一致しません
namespace FluentShouldly;

[ShouldlyMethods]
public static class BeOneOfExtentions
{
    public static void BeOneOf<T>(this IShould<T> should, params T[] expected) => should.Actual.ShouldBeOneOf(expected);

    public static void BeOneOf<T>(this IShould<T> should, T[] expected, string? customMessage) => should.Actual.ShouldBeOneOf(expected, customMessage);

    public static void BeOneOf<T>(this IShould<T> should, T[] expected, IEqualityComparer<T> comparer, string? customMessage = null) => should.Actual.ShouldBeOneOf(expected, customMessage);

    public static void NotBeOneOf<T>(this IShould<T> should, params T[] expected) => should.Actual.ShouldNotBeOneOf(expected);

    public static void NotBeOneOf<T>(this IShould<T> should, T[] expected, string? customMessage) => should.Actual.ShouldNotBeOneOf(expected, customMessage);

    public static void NotBeOneOf<T>(this IShould<T> should, T[] expected, IEqualityComparer<T> comparer, string? customMessage = null) => should.Actual.ShouldNotBeOneOf(expected, comparer, customMessage);
}
