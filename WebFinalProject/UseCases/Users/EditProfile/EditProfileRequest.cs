namespace WebFinalProject.UseCases.Users.EditProfile;

public record EditProfileRequest(
    string Password,
    string Username,
    string Email,
    string Image,
    string Bio
);

