namespace WebFinalProject.Services.JWT;

public record UserToAuth(
    Guid UserID,
    string Username,
    string Plan
);