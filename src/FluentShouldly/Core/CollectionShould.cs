using Shouldly;

namespace FluentShouldly.Core;

[ShouldlyMethods]
public class CollectionShould<T>(ICollection<T> actual) : ObjectShould<ICollection<T>>(actual), IEnumerableShould<T>, ICollectionShould<T>
{
    IEnumerable<T> IEnumerableShould<T>.Actual => Actual;
}
