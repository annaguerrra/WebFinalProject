namespace WebFinalProject.UseCases.Users.Login;

public record LoginRequest(
    string Username,
    string Password,
    string Email
);