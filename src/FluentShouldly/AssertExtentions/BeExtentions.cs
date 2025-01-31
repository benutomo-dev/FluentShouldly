using FluentShouldly.Core;
using Shouldly;
using System.Runtime.CompilerServices;

#pragma warning disable IDE0130 // Namespace がフォルダー構造と一致しません
namespace FluentShouldly;

[ShouldlyMethods]
public static class BeExtentions
{
    [OverloadResolutionPriority(-1)]
    public static void Be<T>(this IShould<T> should, T? expected, string? customMessage = null) => should.Actual.ShouldBe(expected, customMessage);

    [OverloadResolutionPriority(-1)]
    public static void Be<T>(this IShould<T> should, T? expected, IEqualityComparer<T> comparer, string? customMessage = null) => should.Actual.ShouldBe(expected, comparer, customMessage);

    [OverloadResolutionPriority(-1)]
    public static void NotBe<T>(this IShould<T> should, T? expected, string? customMessage = null) => should.Actual.ShouldNotBe(expected, customMessage);

    [OverloadResolutionPriority(-1)]
    public static void NotBe<T>(this IShould<T> should, T? expected, IEqualityComparer<T> comparer, string? customMessage = null) => should.Actual.ShouldNotBe(expected, comparer, customMessage);


    public static void Be<T>(this IEnumerableShould<T> should, IEnumerable<T>? expected, string? customMessage = null) => should.Actual.ShouldBe(expected, customMessage);

    public static void Be<T>(this IEnumerableShould<T> should, IEnumerable<T>? expected, bool ignoreOrder, string? customMessage = null) => should.Actual.ShouldBe(expected, ignoreOrder, customMessage);

    public static void Be<T>(this IEnumerableShould<T> should, IEnumerable<T>? expected, IEqualityComparer<T> comparer, bool ignoreOrder = false, string? customMessage = null) => should.Actual.ShouldBe(expected, comparer, ignoreOrder, customMessage);

    public static void Be(this IEnumerableShould<decimal> should, IEnumerable<decimal> expected, decimal tolerance, string? customMessage = null) => should.Actual.ShouldBe(expected, tolerance, customMessage);

    public static void Be(this IEnumerableShould<float> should, IEnumerable<float> expected, double tolerance, string? customMessage = null) => should.Actual.ShouldBe(expected, tolerance, customMessage);

    public static void Be(this IEnumerableShould<double> should, IEnumerable<double> expected, double tolerance, string? customMessage = null) => should.Actual.ShouldBe(expected, tolerance, customMessage);

    public static void Be(this IEnumerableShould<string> should, IEnumerable<string> expected, Case caseSensitivity, string? customMessage = null) => should.Actual.ShouldBe(expected, (Shouldly.Case)(int)caseSensitivity, customMessage);


    public static void Be(this IShould<float> should, float expected, double tolerance, string? customMessage = null) => should.Actual.ShouldBe(expected, tolerance, customMessage);

    public static void Be(this IShould<double> should, double expected, double tolerance, string? customMessage = null) => should.Actual.ShouldBe(expected, tolerance, customMessage);

    public static void Be(this IShould<decimal> should, decimal expected, decimal tolerance, string? customMessage = null) => should.Actual.ShouldBe(expected, tolerance, customMessage);


    public static void Be(this IStringShould should, string expected, string? customMessage = null) => should.Actual.ShouldBe(expected, customMessage);

    public static void Be(this IStringShould should, string expected, StringCompareShould options) => should.Actual.ShouldBe(expected, (Shouldly.StringCompareShould)(int)options);

    public static void Be(this IStringShould should, string expected, string? customMessage, StringCompareShould options) => should.Actual.ShouldBe(expected, customMessage, (Shouldly.StringCompareShould)(int)options);



    public static void Be(this IShould<DateTime> should, DateTime expected, TimeSpan tolerance, string? customMessage = null) => should.Actual.ShouldBe(expected, tolerance, customMessage);

    public static void Be(this IShould<DateTimeOffset> should, DateTimeOffset expected, TimeSpan tolerance, string? customMessage = null) => should.Actual.ShouldBe(expected, tolerance, customMessage);

    public static void Be(this IShould<TimeSpan> should, TimeSpan expected, TimeSpan tolerance, string? customMessage = null) => should.Actual.ShouldBe(expected, tolerance, customMessage);

    public static void NotBe(this IShould<DateTime> should, DateTime expected, TimeSpan tolerance, string? customMessage = null) => should.Actual.ShouldNotBe(expected, tolerance, customMessage);

    public static void NotBe(this IShould<DateTimeOffset> should, DateTimeOffset expected, TimeSpan tolerance, string? customMessage = null) => should.Actual.ShouldNotBe(expected, tolerance, customMessage);

    public static void NotBe(this IShould<TimeSpan> should, TimeSpan expected, TimeSpan tolerance, string? customMessage = null) => should.Actual.ShouldNotBe(expected, tolerance, customMessage);
}
