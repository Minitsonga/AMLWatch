using AMLWatch.Core.Models;

namespace AMLWatch.Core.DTOs
{
    public record LoginDTO(
        string FirstName,
        string LastName,
        string Username,
        string Email,
        string PasswordHash
    );

}