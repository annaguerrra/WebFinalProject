using System.ComponentModel.DataAnnotations;
using WebFinalProject.Models;
using WebFinalProject.Validations;

namespace WebFinalProject.UseCases.Login;

public record LoginRequest(
    string Login,
    string Password
);
