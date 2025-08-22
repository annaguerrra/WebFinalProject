namespace WebFinalProject.UseCases.User.EditProfile;

public record EditProfileResponse()
{
    public string? Username { get; set; }
    public string? Email { get; set; }
    public string? Bio { get; set; }
    public string? Image { get; set; }
    
}