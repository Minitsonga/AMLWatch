using System;
using System.Collections.Generic;

namespace AMLWatch.Core.Models;
public class Client
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Street { get; set; }
    public string? City { get; set; }
    public string? ZipCode { get; set; }
    public string? Country { get; set; }
    public RiskLevel RiskLevel { get; set; } = RiskLevel.Low;
    public DateTime DateOfRegistration { get; set; }
    public List<Transaction> Transactions { get; set; }

    // Login-related properties
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public DateTime? LastLoginDate { get; set; }

    public Client(string username, string firstName, string lastName, string email, string passwordHash)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Username = username;
        PasswordHash = passwordHash;
        PhoneNumber = string.Empty;
        Street = string.Empty;
        City = string.Empty;
        ZipCode = string.Empty;
        Country = string.Empty;
        RiskLevel = RiskLevel.Low;
        Transactions = new List<Transaction>();
        DateOfRegistration = DateTime.Now;
    }
}

public enum RiskLevel
{
    Low,
    Medium,
    High
}
