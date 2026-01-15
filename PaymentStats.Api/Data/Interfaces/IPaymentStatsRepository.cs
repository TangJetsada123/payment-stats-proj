using PaymentStats.Api.Models;

namespace PaymentStats.Api.Data.Interfaces;

public interface IPaymentStatsRepository
{
    IEnumerable<PaymentTransaction> GetAll();
}
