using AMLWatch.Models;

namespace AMLWatch.DTOs;
public record TransactionDTO(
    Guid Id,
    decimal Amount,
    string DestinationCountry,
    TransactionType Type,
    DateTime Date,
    Guid ClientId
);
