using System.ComponentModel.DataAnnotations;
using WebFinalProject.Models;

namespace WebFinalProject.UseCases.Login;

public record LoginRequest
{
    [Required]
    [MinLength()]
}
