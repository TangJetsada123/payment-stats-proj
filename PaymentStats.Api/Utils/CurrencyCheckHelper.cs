namespace PaymentStats.Api.Utils;

public static class CurrencyHelper
{
    public static string Normalize(string? currency)
        => currency?.Trim().ToUpperInvariant() ?? "";
}
