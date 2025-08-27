namespace WebFinalProject.UseCases.Users.Login;

public record LoginRequest(
    string username,
    string password
);