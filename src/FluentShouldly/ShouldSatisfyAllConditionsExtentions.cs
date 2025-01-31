using Shouldly;

namespace FluentShouldly;

[ShouldlyMethods]
public static class ShouldSatisfyAllConditionsExtentions
{
    public static void ShouldSatisfyAllConditions<T>(this T actual, params Action<T>[] conditions) where T : notnull => Shouldly.ShouldSatisfyAllConditionsTestExtensions.ShouldSatisfyAllConditions(actual, conditions);

    public static void ShouldSatisfyAllConditions<T>(this T actual, string? customMessage, params Action<T>[] conditions) where T : notnull => Shouldly.ShouldSatisfyAllConditionsTestExtensions.ShouldSatisfyAllConditions(actual, customMessage, conditions);
}
