
namespace WebFinalProject.Services.JWT;
using WebFinalProject.Services.LoginService;

public interface IJWTServices
{
    string CreateToken(LoginService data);
}