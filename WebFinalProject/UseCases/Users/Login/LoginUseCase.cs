
using Microsoft.EntityFrameworkCore;

using WebFinalProject.Infrastructure;

using WebFinalProject.Models;
using WebFinalProject.Services.JWT;
using WebFinalProject.Services.Password;

namespace WebFinalProject.UseCases.Users.Login;

public class LoginUseCase(
    IJWTServices jwt,
    WebFinalProjectDbContext ctx
)
{
    public async Task<Result<LoginResponse>> Do(LoginRequest payload)
    {
        var profile = await ctx.Users.FirstOrDefaultAsync(
            p => p.Username == payload.Username || p.Email == payload.Email
        );

        if (profile.Password != payload.Password)
            return Result<LoginResponse>.BadRequest("Login or Password are incorrects");

        var token = jwt.CreateToken();
        return Result<LoginResponse>.Ok();
    }
}