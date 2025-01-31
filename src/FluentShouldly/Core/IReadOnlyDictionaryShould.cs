#if NET9_0_OR_GREATER
namespace FluentShouldly.Core;

public interface IReadOnlyDictionaryShould<TKey, TValue>
{
    IReadOnlyDictionary<TKey, TValue> Actual { get; }
}
#endif
