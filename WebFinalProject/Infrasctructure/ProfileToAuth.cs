namespace WebFinalProject.Infrastructure;

public class ProfileToAuth
{
    public required Guid ID { get; set; }
    public required string Username { get; set; }
    public required string Email { get; set; }
}
