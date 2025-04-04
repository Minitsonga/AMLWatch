using AMLWatch.Models;

namespace AMLWatch.DTOs;

public record LoginDTO(
    string FirstName,
    string LastName,
    string Username,
    string Email,
    string PasswordHash
);

