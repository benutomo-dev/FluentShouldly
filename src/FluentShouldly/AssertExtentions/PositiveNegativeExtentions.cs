using FluentShouldly.Core;
using Shouldly;

#pragma warning disable IDE0130 // Namespace がフォルダー構造と一致しません
namespace FluentShouldly;

[ShouldlyMethods]
public static class PositiveNegativeExtentions
{
    public static void BePositive(this IShould<decimal> should, string? customMessage = null) => should.Actual.ShouldBePositive(customMessage);

    public static void BeNegative(this IShould<decimal> should, string? customMessage = null) => should.Actual.ShouldBeNegative(customMessage);

    public static void BePositive(this IShould<double> should, string? customMessage = null) => should.Actual.ShouldBePositive(customMessage);

    public static void BeNegative(this IShould<double> should, string? customMessage = null) => should.Actual.ShouldBeNegative(customMessage);

    public static void BePositive(this IShould<float> should, string? customMessage = null) => should.Actual.ShouldBePositive(customMessage);

    public static void BeNegative(this IShould<float> should, string? customMessage = null) => should.Actual.ShouldBeNegative(customMessage);

    public static void BePositive(this IShould<int> should, string? customMessage = null) => should.Actual.ShouldBePositive(customMessage);

    public static void BeNegative(this IShould<int> should, string? customMessage = null) => should.Actual.ShouldBeNegative(customMessage);

    public static void BePositive(this IShould<long> should, string? customMessage = null) => should.Actual.ShouldBePositive(customMessage);

    public static void BeNegative(this IShould<long> should, string? customMessage = null) => should.Actual.ShouldBeNegative(customMessage);

    public static void BePositive(this IShould<short> should, string? customMessage = null) => should.Actual.ShouldBePositive(customMessage);

    public static void BeNegative(this IShould<short> should, string? customMessage = null) => should.Actual.ShouldBeNegative(customMessage);
}
