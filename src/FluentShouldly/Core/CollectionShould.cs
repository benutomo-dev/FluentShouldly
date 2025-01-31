using Shouldly;

namespace FluentShouldly.Core;

[ShouldlyMethods]
public class CollectionShould<T> : ObjectShould<ICollection<T>>, IEnumerableShould<T>, ICollectionShould<T>
{
    IEnumerable<T> IEnumerableShould<T>.Actual => Actual;

    public CollectionShould(ICollection<T> actual) : base(actual) { }
}
