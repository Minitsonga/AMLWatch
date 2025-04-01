using AMLWatch.Core.Models;

public record TransactionDTO(
    Guid Id,
    decimal Amount,
    string DestinationCountry,
    TransactionType Type,
    DateTime Date,
    Guid ClientId
);
