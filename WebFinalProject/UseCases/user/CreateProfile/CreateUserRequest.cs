using WebFinalProject.Validations;
namespace WebFinalProject.UseCases.User.CreateUser;

public record CreateUserRequest
{
    [Required]
    [MinLength(6)]
    [MaxLength(12)]
    public string Username { get; init; }

    [Required]
    []
}