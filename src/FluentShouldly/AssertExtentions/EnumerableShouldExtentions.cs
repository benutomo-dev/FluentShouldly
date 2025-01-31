using FluentShouldly.Core;
using Shouldly;
using System.Linq.Expressions;

#pragma warning disable IDE0130 // Namespace がフォルダー構造と一致しません
namespace FluentShouldly;

[ShouldlyMethods]
public static class EnumerableShouldExtentions
{
    public static void Contain<T>(this IEnumerableShould<T> should, T expected, string? customMessage = null) => should.Actual.ShouldContain(expected, customMessage);

    public static void Contain<T>(this IEnumerableShould<T> should, T expected, IEqualityComparer<T> comparer, string? customMessage = null) => should.Actual.ShouldContain(expected, comparer, customMessage);

    public static void NotContain<T>(this IEnumerableShould<T> should, T expected, string? customMessage = null) => should.Actual.ShouldNotContain(expected, customMessage);

    public static void NotContain<T>(this IEnumerableShould<T> should, T expected, IEqualityComparer<T> comparer, string? customMessage = null) => should.Actual.ShouldNotContain(expected, comparer, customMessage);

    public static void Contain<T>(this IEnumerableShould<T> should, Expression<Func<T, bool>> elementPredicate, int expectedCount, string? customMessage = null) => should.Actual.ShouldContain(elementPredicate, expectedCount, customMessage);

    public static void Contain<T>(this IEnumerableShould<T> should, Expression<Func<T, bool>> elementPredicate, string? customMessage = null) => should.Actual.ShouldContain(elementPredicate, customMessage);

    public static void NotContain<T>(this IEnumerableShould<T> should, Expression<Func<T, bool>> elementPredicate, string? customMessage = null) => should.Actual.ShouldNotContain(elementPredicate, customMessage);

    public static void AllBe<T>(this IEnumerableShould<T> should, Expression<Func<T, bool>> elementPredicate, string? customMessage = null) => should.Actual.ShouldAllBe(elementPredicate, customMessage);

    public static void BeEmpty<T>(this IEnumerableShould<T> should, string? customMessage = null) => should.Actual.ShouldBeEmpty(customMessage);

    public static void NotBeEmpty<T>(this IEnumerableShould<T> should, string? customMessage = null) => should.Actual.ShouldNotBeEmpty(customMessage);

    public static T HaveSingleItem<T>(this IEnumerableShould<T> should, string? customMessage = null) => should.Actual.ShouldHaveSingleItem(customMessage);

    public static void Contain(this IEnumerableShould<float> should, float expected, double tolerance, string? customMessage = null) => should.Actual.ShouldContain(expected, tolerance, customMessage);

    public static void Contain(this IEnumerableShould<double> should, double expected, double tolerance, string? customMessage = null) => should.Actual.ShouldContain(expected, tolerance, customMessage);

    public static void BeSubsetOf<T>(this IEnumerableShould<T> should, IEnumerable<T> expected, string? customMessage = null) => should.Actual.ShouldBeSubsetOf(expected, customMessage);

    public static void BeSubsetOf<T>(this IEnumerableShould<T> should, IEnumerable<T> expected, IEqualityComparer<T> comparer, string? customMessage = null) => should.Actual.ShouldBeSubsetOf(expected, customMessage);

    public static void BeUnique<T>(this IEnumerableShould<T> should, string? customMessage = null) => should.Actual.ShouldBeUnique(customMessage);

    public static void BeUnique<T>(this IEnumerableShould<T> should, IEqualityComparer<T> comparer) => should.Actual.ShouldBeUnique(comparer);

    public static void BeUnique<T>(this IEnumerableShould<T> should, IEqualityComparer<T> comparer, string? customMessage) => should.Actual.ShouldBeUnique(comparer, customMessage);

    public static void Be(this IEnumerableShould<string> should, IEnumerable<string> expected, Case caseSensitivity, string? customMessage = null) => should.Actual.ShouldBe(expected, (Shouldly.Case)(int)caseSensitivity, customMessage);

    public static void BeInOrder<T>(this IEnumerableShould<T> should, string? customMessage = null) => should.Actual.ShouldBeInOrder(customMessage);

    public static void BeInOrder<T>(this IEnumerableShould<T> should, SortDirection expectedSortDirection, string? customMessage = null) => should.Actual.ShouldBeInOrder(expectedSortDirection, customMessage);

    public static void BeInOrder<T>(this IEnumerableShould<T> should, SortDirection expectedSortDirection, IComparer<T>? customComparer, string? customMessage = null) => should.Actual.ShouldBeInOrder(expectedSortDirection, customComparer, customMessage);

    public static void BeOfTypes<T>(this IEnumerableShould<T> should, params Type[] expected) => should.Actual.ShouldBeOfTypes(expected);

    public static void BeOfTypes<T>(this IEnumerableShould<T> should, Type[] expected, string? customMessage) => should.Actual.ShouldBeOfTypes(expected, customMessage);
}
