#if NET9_0_OR_GREATER
using Shouldly;

namespace FluentShouldly.Core;

[ShouldlyMethods]
public class ReadOnlyDictionaryShould<TKey, TValue> : ObjectShould<IReadOnlyDictionary<TKey, TValue>>, IEnumerableShould<KeyValuePair<TKey, TValue>>, IReadOnlyCollectionShould<KeyValuePair<TKey, TValue>>, IReadOnlyDictionaryShould<TKey, TValue>//, IShould<ICollection<KeyValuePair<TKey, TValue>>>
{
    IEnumerable<KeyValuePair<TKey, TValue>> IEnumerableShould<KeyValuePair<TKey, TValue>>.Actual => Actual;
    IReadOnlyCollection<KeyValuePair<TKey, TValue>> IReadOnlyCollectionShould<KeyValuePair<TKey, TValue>>.Actual => Actual;

    public ReadOnlyDictionaryShould(IReadOnlyDictionary<TKey, TValue> actual) : base(actual) { }
}
#endif
