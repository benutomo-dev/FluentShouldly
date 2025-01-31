using Shouldly;

namespace FluentShouldly.Core;

[ShouldlyMethods]
public class StringShould(string? actual) : ObjectShould<string?>(actual), IStringShould
{
}
