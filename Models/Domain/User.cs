using Microsoft.AspNetCore.Identity;

namespace ServiceMate.Models.Domain;

public class User: IdentityUser
{
    public Guid Id { get; set; }
    public string? UserName { get; set; }
    public string? Email { get; set; }
    public string? PasswordHash { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}