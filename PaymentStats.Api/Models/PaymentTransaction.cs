using System.ComponentModel.DataAnnotations;

namespace PaymentStats.Api.Models;

public class PaymentTransaction
{
    [Key]
    public Guid TransactionId { get; set; }
    public decimal PaymentAmount { get; set; }
    public string Currency { get; set; } = "";
    public DateTime CreatedAt { get; set; }
}
