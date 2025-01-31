namespace FluentShouldly.Core;

public interface ICollectionShould<T>
{
    ICollection<T> Actual { get; }
}
