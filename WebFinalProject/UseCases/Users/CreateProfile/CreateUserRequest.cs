using System.ComponentModel.DataAnnotations;
using WebFinalProject.Validations;
namespace WebFinalProject.UseCases.Users.CreateUser;

public record CreateUserRequest
{
    [Required]
    [MinLength(6)]
    [MaxLength(12)]
    public string Username { get; init; }

    [Required]
    public string Bio { get; init; }

    [EmailAddress]
    public string Email { get; init; }

    [Required]
    [MinLength(8)]
    [NeedNumber]
    [IsUpperLowerCase]
    [SpecialChar]
    public string Password { get; init; }
}
