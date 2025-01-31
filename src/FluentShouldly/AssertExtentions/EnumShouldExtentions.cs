using FluentShouldly.Core;
using Shouldly;
using Shouldly.ShouldlyExtensionMethods;

#pragma warning disable IDE0130 // Namespace がフォルダー構造と一致しません
namespace FluentShouldly;

[ShouldlyMethods]
public static class EnumShouldExtentions
{
    public static void HaveFlag<T>(this IShould<T> should, T expectedFlag, string? customMessage = null) where T : struct, Enum => should.Actual.ShouldHaveFlag(expectedFlag, customMessage);

    public static void NotHaveFlag<T>(this IShould<T> should, T expectedFlag, string? customMessage = null) where T : struct, Enum => should.Actual.ShouldNotHaveFlag(expectedFlag, customMessage);
}
