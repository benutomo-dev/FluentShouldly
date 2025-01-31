using FluentShouldly.Core;
using Shouldly;

#pragma warning disable IDE0130 // Namespace がフォルダー構造と一致しません
namespace FluentShouldly;

[ShouldlyMethods]
public static class BeEquivalentToExtentions
{
    public static void BeEquivalentTo<T>(this INotTypeShould<T> should, T? expected, string? customMessage = null) where T : class => should.Actual.ShouldBeEquivalentTo(expected, customMessage);
}
