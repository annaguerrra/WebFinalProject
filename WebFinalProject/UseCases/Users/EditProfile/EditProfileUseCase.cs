using Microsoft.AspNetCore.Http.HttpResults;
using WebFinalProject.Models;
using WebFinalProject.Services.Password;

namespace WebFinalProject.UseCases.Users.EditProfile;

public class EditProfileUseCase(
    WebFinalProjectDbContext ctx,
    IPasswordService password
)
{
    public async Task<Result<EditProfileResponse>> Do(EditProfileRequest request)
    {
        var user = new User
        {
            Password = request.Password
        };

        ctx.Update(user);
        await ctx.SaveChangesAsync();

        return Result<EditProfileResponse>.Ok(new());
    }
}