using Shouldly;

namespace FluentShouldly.Core;

[ShouldlyMethods]
public class StringShould : ObjectShould<string?>, IStringShould
{
    public StringShould(string? actual) : base(actual) { }
}
