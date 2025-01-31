using Shouldly;

namespace FluentShouldly.Core;

[ShouldlyMethods]
public class EnumerableShould<T>(IEnumerable<T> actual) : ObjectShould<IEnumerable<T>>(actual), IEnumerableShould<T>
{
}
