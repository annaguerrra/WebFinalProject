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
