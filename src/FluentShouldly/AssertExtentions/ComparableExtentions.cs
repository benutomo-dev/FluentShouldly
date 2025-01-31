using FluentShouldly.Core;
using Shouldly;

#pragma warning disable IDE0130 // Namespace がフォルダー構造と一致しません
namespace FluentShouldly;

[ShouldlyMethods]
public static class ComparableExtentions
{
    public static void BeGreaterThan<T>(this IShould<T> should, T expected, IComparer<T> comparer, string? customMessage = null) => should.Actual.ShouldBeGreaterThan(expected, comparer, customMessage);

    public static void BeGreaterThan<T>(this IShould<T> should, T expected, string? customMessage = null) where T : IComparable<T> => should.Actual.ShouldBeGreaterThan(expected, customMessage);

    public static void BeLessThan<T>(this IShould<T> should, T expected, IComparer<T> comparer, string? customMessage = null) => should.Actual.ShouldBeLessThan(expected, comparer, customMessage);

    public static void BeLessThan<T>(this IShould<T> should, T expected, string? customMessage = null) where T : IComparable<T> => should.Actual.ShouldBeLessThan(expected, customMessage);

    public static void BeGreaterThanOrEqualTo<T>(this IShould<T> should, T expected, IComparer<T> comparer, string? customMessage = null) => should.Actual.ShouldBeGreaterThanOrEqualTo(expected, comparer, customMessage);

    public static void BeGreaterThanOrEqualTo<T>(this IShould<T> should, T expected, string? customMessage = null) where T : IComparable<T> => should.Actual.ShouldBeGreaterThanOrEqualTo(expected, customMessage);

    public static void BeLessThanOrEqualTo<T>(this IShould<T> should, T expected, IComparer<T> comparer, string? customMessage = null) => should.Actual.ShouldBeLessThanOrEqualTo(expected, comparer, customMessage);

    public static void BeLessThanOrEqualTo<T>(this IShould<T> should, T expected, string? customMessage = null) where T : IComparable<T> => should.Actual.ShouldBeLessThanOrEqualTo(expected, customMessage);

    public static void BeInRange<T>(this IShould<T> should, T? from, T? to, string? customMessage = null) where T : IComparable<T> => should.Actual.ShouldBeInRange(from, to, customMessage);

    public static void NotBeInRange<T>(this IShould<T> should, T? from, T? to, string? customMessage = null) where T : IComparable<T> => should.Actual.ShouldNotBeInRange(from, to, customMessage);
}
