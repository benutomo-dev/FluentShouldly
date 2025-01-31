namespace FluentShouldly.Core;

public interface IReadOnlyCollectionShould<T>
{
    IReadOnlyCollection<T> Actual { get; }
}
