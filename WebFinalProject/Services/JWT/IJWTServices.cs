namespace WebFinalProject.Services.JWT;

public interface IJWTServices
{
    string CreateToken(UserToAuth data);
}