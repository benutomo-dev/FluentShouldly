using FluentShouldly.Core;
using Shouldly;

#pragma warning disable IDE0130 // Namespace がフォルダー構造と一致しません
namespace FluentShouldly;

[ShouldlyMethods]
public static class StringShouldExtentions
{
    public static void ContainWithoutWhitespace(this IStringShould should, object? expected, string? customMessage = null) => should.Actual!.ShouldContainWithoutWhitespace(expected, customMessage);

    public static void Contain(this IStringShould should, string expected, Case caseSensitivity = Case.Insensitive, string? customMessage = null) => should.Actual!.ShouldContain(expected, (Shouldly.Case)(int)caseSensitivity, customMessage);

    public static void NotContain(this IStringShould should, string expected, Case caseSensitivity = Case.Insensitive, string? customMessage = null) => should.Actual!.ShouldNotContain(expected, (Shouldly.Case)(int)caseSensitivity, customMessage);

    public static void Match(this IStringShould should, string regexPattern, string? customMessage = null) => should.Actual!.ShouldMatch(regexPattern, customMessage);

    public static void NotMatch(this IStringShould should, string regexPattern, string? customMessage = null) => should.Actual!.ShouldNotMatch(regexPattern, customMessage);

    public static void BeNullOrEmpty(this IStringShould should, string? customMessage = null) => should.Actual.ShouldBeNullOrEmpty(customMessage);

    public static void NotBeNullOrEmpty(this IStringShould should, string? customMessage = null) => should.Actual.ShouldNotBeNullOrEmpty(customMessage);

    public static void BeNullOrWhiteSpace(this IStringShould should, string? customMessage = null) => should.Actual.ShouldBeNullOrWhiteSpace(customMessage);

    public static void NotBeNullOrWhiteSpace(this IStringShould should, string? customMessage = null) => should.Actual.ShouldNotBeNullOrWhiteSpace(customMessage);

    public static void StartWith(this IStringShould should, string expected, Case caseSensitivity = Case.Insensitive, string? customMessage = null) => should.Actual.ShouldStartWith(expected, (Shouldly.Case)(int)caseSensitivity, customMessage);

    public static void NotStartWith(this IStringShould should, string expected, Case caseSensitivity = Case.Insensitive, string? customMessage = null) => should.Actual.ShouldNotStartWith(expected, (Shouldly.Case)(int)caseSensitivity, customMessage);

    public static void EndWith(this IStringShould should, string expected, Case caseSensitivity = Case.Insensitive, string? customMessage = null) => should.Actual.ShouldEndWith(expected, (Shouldly.Case)(int)caseSensitivity, customMessage);

    public static void NotEndWith(this IStringShould should, string expected, Case caseSensitivity = Case.Insensitive, string? customMessage = null) => should.Actual.ShouldNotEndWith(expected, customMessage, (Shouldly.Case)(int)caseSensitivity);
}
