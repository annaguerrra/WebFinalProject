namespace WebFinalProject.UseCases.Users.CreateProfile;

public record CreateProfileRequest(
   
    string Username, 
    string Password,
    string Bio

);