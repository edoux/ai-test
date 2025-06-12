using System.Text.Json.Serialization;

namespace DemoSentryApp.Request;

public class Equation
{
    [JsonNumberHandling(JsonNumberHandling.AllowNamedFloatingPointLiterals)]
    public required double Value { get; init; }
}