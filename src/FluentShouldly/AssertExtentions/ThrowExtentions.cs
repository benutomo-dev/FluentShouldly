using FluentShouldly.Core;
using Shouldly;

#pragma warning disable IDE0130 // Namespace がフォルダー構造と一致しません
namespace FluentShouldly;

[ShouldlyMethods]
public static class ThrowExtentions
{
    public static Exception ShouldThrow(this IShould<Action> should, Type exceptionType, string? customMessage = null) => should.Actual.ShouldThrow(exceptionType, customMessage);

    public static void ShouldNotThrow(this IShould<Action> should, string? customMessage = null) => should.Actual.ShouldNotThrow(customMessage);

    public static async Task<Exception> ShouldThrowAsync(this IShould<Func<Task>> should, Type exceptionType, string? customMessage = null) => await should.Actual.ShouldThrowAsync(exceptionType, customMessage).ConfigureAwait(false);

    public static async Task ShouldNotThrowAsync(this IShould<Func<Task>> should, string? customMessage = null) => await should.Actual.ShouldNotThrowAsync(customMessage).ConfigureAwait(false);
}
