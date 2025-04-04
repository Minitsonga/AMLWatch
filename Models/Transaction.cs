namespace AMLWatch.Models;
public class Transaction
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public decimal Amount { get; set; }
    public string DestinationCountry { get; set; }
    public TransactionType Type { get; set; }
    public DateTime Date { get; set; } = DateTime.UtcNow;

    public Guid ClientId { get; set; }
    public Client Client { get; set; }
}

public enum TransactionType
{
    Transfer,
    Deposit,
    Withdrawal
}