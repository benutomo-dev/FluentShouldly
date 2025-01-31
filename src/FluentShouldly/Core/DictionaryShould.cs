using Shouldly;

namespace FluentShouldly.Core;

[ShouldlyMethods]
public class DictionaryShould<TKey, TValue> : ObjectShould<IDictionary<TKey, TValue>>, IEnumerableShould<KeyValuePair<TKey, TValue>>, ICollectionShould<KeyValuePair<TKey, TValue>>, IDictionaryShould<TKey, TValue>//, IShould<ICollection<KeyValuePair<TKey, TValue>>>
{
    IEnumerable<KeyValuePair<TKey, TValue>> IEnumerableShould<KeyValuePair<TKey, TValue>>.Actual => Actual;
    ICollection<KeyValuePair<TKey, TValue>> ICollectionShould<KeyValuePair<TKey, TValue>>.Actual => Actual;

    public DictionaryShould(IDictionary<TKey, TValue> actual) : base(actual) { }
}
