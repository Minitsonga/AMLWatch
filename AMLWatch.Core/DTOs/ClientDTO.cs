using AMLWatch.Core.Models;

namespace AMLWatch.Core.DTOs
{
    public record ClientDTO(
        Guid Id,
        string Username,
        string Email,
        AdressDTO? Address
    );

}