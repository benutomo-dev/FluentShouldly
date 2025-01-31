using FluentShouldly.Core;
using Shouldly;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace FluentShouldly;

#nullable disable warnings

[ShouldlyMethods]
public static class ShouldExtentions
{
    [OverloadResolutionPriority(-1)]
    public static ObjectShould<T> Should<T>([NotNull] this T actual) => new ObjectShould<T>(actual);

    public static TypeShould Should([NotNull] this Type? actual) => new TypeShould(actual);

    public static StringShould Should([NotNull] this string? actual) => new StringShould(actual);

    public static EnumerableShould<T> Should<T>([NotNull] this IEnumerable<T>? actual) => new EnumerableShould<T>(actual);

    public static CollectionShould<T> Should<T>([NotNull] this ICollection<T>? actual) => new CollectionShould<T>(actual);

    public static DictionaryShould<TKey, TValue> Should<TKey, TValue>([NotNull] this IDictionary<TKey, TValue>? actual) => new DictionaryShould<TKey, TValue>(actual);

#if NET9_0_OR_GREATER
    [OverloadResolutionPriority(1)]
    public static ReadOnlyDictionaryShould<TKey, TValue> Should<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> actual) => new ReadOnlyDictionaryShould<TKey, TValue>(actual);
#endif
}
