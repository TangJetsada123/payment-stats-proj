using PaymentStats.Api.DTO;
using PaymentStats.Api.Models;

namespace PaymentStats.Api.Services.Interfaces;

public interface IPaymentStatsService
{
    PaymentStatsDto Calculate(string? currency);
    List<PaymentTransaction> GetPaymentStatsList(string? currency);
}
