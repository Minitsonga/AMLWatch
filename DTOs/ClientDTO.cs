using AMLWatch.Models;

namespace AMLWatch.DTOs
{
    public record ClientDTO(
        Guid Id,
        string Username,
        string Email,
        AdressDTO? Address
    );

}