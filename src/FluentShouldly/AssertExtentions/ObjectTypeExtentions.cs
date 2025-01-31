using FluentShouldly.Core;
using Shouldly;

#pragma warning disable IDE0130 // Namespace がフォルダー構造と一致しません
namespace FluentShouldly;

[ShouldlyMethods]
public static class ObjectTypeExtentions
{
    public static void BeAssignableTo<T>(this INotTypeShould<T> should, Type expected, string? customMessage = null) => should.Actual.ShouldBeAssignableTo(expected, customMessage);

    public static void BeOfType<T>(this INotTypeShould<T> should, Type expected, string? customMessage = null) => should.Actual.ShouldBeOfType(expected, customMessage);

    public static void NotBeAssignableTo<T>(this INotTypeShould<T> should, Type expected, string? customMessage = null) => should.Actual.ShouldNotBeAssignableTo(expected, customMessage);

    public static void NotBeOfType<T>(this INotTypeShould<T> should, Type expected, string? customMessage = null) => should.Actual.ShouldNotBeOfType(expected, customMessage);
}
