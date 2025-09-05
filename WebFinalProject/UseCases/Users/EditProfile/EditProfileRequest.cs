namespace WebFinalProject.UseCases.Users.EditProfile;

public record EditProfileRequest(
    Guid ID,
    string Password,
    string Username,
    string Email,
    string Image,
    string Bio
);

