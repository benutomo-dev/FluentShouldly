using FluentShouldly.Core;
using Shouldly;

#pragma warning disable IDE0130 // Namespace がフォルダー構造と一致しません
namespace FluentShouldly;

[ShouldlyMethods]
public static class DictionaryShouldExtentions
{
    public static void ContainKey<TKey, TValue>(this IDictionaryShould<TKey, TValue> should, TKey key, string? customMessage = null) where TKey : notnull => should.Actual.ShouldContainKey(key, customMessage);

    public static void NotContainKey<TKey, TValue>(this IDictionaryShould<TKey, TValue> should, TKey key, string? customMessage = null) where TKey : notnull => should.Actual.ShouldNotContainKey(key, customMessage);

    public static void ContainKeyAndValue<TKey, TValue>(this IDictionaryShould<TKey, TValue> should, TKey key, TValue val, string? customMessage = null) where TKey : notnull => should.Actual.ShouldContainKeyAndValue(key, val, customMessage);

    public static void NotContainValueForKey<TKey, TValue>(this IDictionaryShould<TKey, TValue> should, TKey key, TValue val, string? customMessage = null) where TKey : notnull => should.Actual.ShouldNotContainValueForKey(key, val, customMessage);
}
