using Shouldly;

namespace FluentShouldly.Core;

[ShouldlyMethods]
public class EnumerableShould<T> : ObjectShould<IEnumerable<T>>, IEnumerableShould<T>
{
    public EnumerableShould(IEnumerable<T> actual) : base(actual) { }
}
