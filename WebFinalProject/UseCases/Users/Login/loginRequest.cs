namespace WebFinalProject.UseCases.User.Login;

public record LoginRequest(
    string username,
    string password
);