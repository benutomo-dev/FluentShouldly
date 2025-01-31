namespace FluentShouldly.Core;

public interface IShould<T>
{
    T Actual { get; }
}
