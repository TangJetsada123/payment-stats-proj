using System.Text.Json;
using PaymentStats.Api.Models;
using PaymentStats.Api.Data.Interfaces;

namespace PaymentStats.Api.Data;

public class PaymentStatsRepository : IPaymentStatsRepository
{
    private readonly List<PaymentTransaction> _data;

    public PaymentStatsRepository()
    {
        var filePath = "payment_data.json";
        
        if (File.Exists(filePath))
        {
            var jsonString = File.ReadAllText(filePath);
            
            _data = JsonSerializer.Deserialize<List<PaymentTransaction>>(jsonString, 
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) 
                ?? new List<PaymentTransaction>();
        }
        else
        {
            _data = new List<PaymentTransaction>();
        }
    }

    public IEnumerable<PaymentTransaction> GetAll() => _data;
}