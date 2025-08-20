using System.ComponentModel.DataAnnotations;
using WebFinalProject.Models;

namespace WebFinalProject.UseCases.Login;

public record LoginRequest
{
    // validação pra ver se o nome de usuário já existe
    [Required]
    [MinLength()]
}
