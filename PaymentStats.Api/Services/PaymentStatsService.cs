using PaymentStats.Api.Data.Interfaces;
using PaymentStats.Api.DTO;
using PaymentStats.Api.Services.Interfaces;
using PaymentStats.Api.Utils;
using PaymentStats.Api.Models;

namespace PaymentStats.Api.Services;

public class PaymentStatsService : IPaymentStatsService
{
    private readonly IPaymentStatsRepository _repository;

    public PaymentStatsService(IPaymentStatsRepository repository)
    {
        _repository = repository;
    }

    public PaymentStatsDto Calculate(string? currency)
    {
        var normalized = CurrencyHelper.Normalize(currency);

        var amounts = _repository.GetAll()
            .Where(x => string.IsNullOrEmpty(normalized) || x.Currency == normalized)
            .Select(x => x.PaymentAmount)
            .ToList();

        if (!amounts.Any())
            throw new InvalidOperationException("No data found");

        return new PaymentStatsDto
        {
            Min = amounts.Min(),
            Max = amounts.Max(),
            Average = amounts.Average(),
            Count = amounts.Count
        };
    }

    public List<PaymentTransaction> GetPaymentStatsList(string? currency)
    {
        var normalized = CurrencyHelper.Normalize(currency);
        var amounts = _repository.GetAll()
        .Where(x => string.IsNullOrEmpty(normalized) || x.Currency == normalized)
        .ToList();

        if (!amounts.Any())
            throw new InvalidOperationException("No data found");

        return amounts;
    }
}
