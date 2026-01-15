namespace PaymentStats.Api.DTO;

public class PaymentStatsDto
{
    public decimal Min { get; set; }
    public decimal Max { get; set; }
    public decimal Average { get; set; }
    public int Count { get; set; }
}
