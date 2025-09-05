using Microsoft.EntityFrameworkCore;
using WebFinalProject.Models;
using WebFinalProject.Services.Password;
namespace WebFinalProject.UseCases.Users.CreateUser;

public class CreateUserUseCase(
    IPasswordService password,
    WebFinalProjectDbContext ctx
)
{
    public async Task<Result<CreateUserResponse>> Do(CreateUserRequest payload)
    {
        var username = await ctx.Users.FindAsync(payload.Username);
        var email = await ctx.Users.FindAsync(payload.Email);
        
        if (username is not null)
            return Result<CreateUserResponse>.BadRequest("Username unavailable");

        if (email is not null)
            return Result<CreateUserResponse>.BadRequest("Email unavailable");

        var user = new User
        {
            Username = payload.Username,
            Email = payload.Email,
            Password = password.Hash(payload.Password),
            Bio = payload.Bio
        };

        ctx.Users.Add(user);
        await ctx.SaveChangesAsync();

        return Result<CreateUserResponse>.Ok(new ());
    }
}
