using FluentShouldly.Core;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace FluentShouldly;

#nullable disable warnings

public static class ShouldExtentions
{
    [OverloadResolutionPriority(int.MinValue)]
    public static ObjectShould<object?> Should(object? actual) => new ObjectShould<object?>(actual);

    [OverloadResolutionPriority(-1)]
    public static ObjectShould<T> Should<T>([NotNull] this T actual) => new ObjectShould<T>(actual);

    // Typeは一般の型とは異なる扱いにするためにTypeに対してObjectShould<Type>よりも優先される専用のShould型を用意
    public static TypeShould Should([NotNull] this Type? actual) => new TypeShould(actual);

    // stringをIEnumerable<char>として扱わせないためにstringに対してEnumerableShould<char>よりも優先される専用のShould型を用意
    public static StringShould Should([NotNull] this string? actual) => new StringShould(actual);

    public static EnumerableShould<T> Should<T>([NotNull] this IEnumerable<T>? actual) => new EnumerableShould<T>(actual);

    public static CollectionShould<T> Should<T>([NotNull] this ICollection<T>? actual) => new CollectionShould<T>(actual);

    public static DictionaryShould<TKey, TValue> Should<TKey, TValue>([NotNull] this IDictionary<TKey, TValue>? actual) => new DictionaryShould<TKey, TValue>(actual);

#if NET9_0_OR_GREATER
    [OverloadResolutionPriority(1)]
    public static ReadOnlyDictionaryShould<TKey, TValue> Should<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> actual) => new ReadOnlyDictionaryShould<TKey, TValue>(actual);
#endif
}
