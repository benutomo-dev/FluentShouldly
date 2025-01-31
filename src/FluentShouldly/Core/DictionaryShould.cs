using Shouldly;

namespace FluentShouldly.Core;

[ShouldlyMethods]
public class DictionaryShould<TKey, TValue>(IDictionary<TKey, TValue> actual) : ObjectShould<IDictionary<TKey, TValue>>(actual), IEnumerableShould<KeyValuePair<TKey, TValue>>, ICollectionShould<KeyValuePair<TKey, TValue>>, IDictionaryShould<TKey, TValue>//, IShould<ICollection<KeyValuePair<TKey, TValue>>>
{
    IEnumerable<KeyValuePair<TKey, TValue>> IEnumerableShould<KeyValuePair<TKey, TValue>>.Actual => Actual;
    ICollection<KeyValuePair<TKey, TValue>> ICollectionShould<KeyValuePair<TKey, TValue>>.Actual => Actual;
}
