namespace FluentShouldly.Core;

public interface IEnumerableShould<T>
{
    IEnumerable<T> Actual { get; }
}
