namespace FluentShouldly;

[Flags]
public enum StringCompareShould
{
    IgnoreCase = Shouldly.StringCompareShould.IgnoreCase,
    IgnoreLineEndings = Shouldly.StringCompareShould.IgnoreLineEndings,
}
