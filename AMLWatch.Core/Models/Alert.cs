namespace AMLWatch.Core.Models;
public class Alert
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime DetectionDate { get; set; } = DateTime.UtcNow;
    public AlertType AlertType { get; set; }
    public AlertStatus Status { get; set; } = AlertStatus.New;
    public string Comment { get; set; }

    public Guid? TransactionId { get; set; }
    public Transaction Transaction { get; set; }

    public Guid ClientId { get; set; }
    public Client Client { get; set; }
}

public enum AlertType
{
    HighAmount,
    FrequentTransactions,
    RiskCountry,
    Smurfing
}

public enum AlertStatus
{
    New,
    Reviewed,
    Escalated
}
