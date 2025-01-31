namespace FluentShouldly.Core;

public interface IDictionaryShould<TKey, TValue>
{
    IDictionary<TKey, TValue> Actual { get; }
}
