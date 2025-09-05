using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using WebFinalProject.Models;
using WebFinalProject.Services.Password;

namespace WebFinalProject.UseCases.Users.EditProfile;

public class EditProfileUseCase(
    WebFinalProjectDbContext ctx,
    IPasswordService password
)
{
    public async Task<Result<EditProfileResponse>> Do(EditProfileRequest payload)
    {
        var user = await ctx.Users.FirstAsync(
              u => u.ID == payload.ID
        );

        if (user is null)
            return Result<EditProfileResponse>.BadRequest("User not found.");
        
        if (payload.Email is not null)
            user.Email = payload.Email;
        
        if(payload.Username is not null)
            user.Username = payload.Username;
        
        if(payload.Image is not null)
            user.Image = payload.Image;
        
        if(payload.Bio is not null)
            user.Bio = payload.Bio;

        ctx.Update(user);
        await ctx.SaveChangesAsync();

        return Result<EditProfileResponse>.Ok(new());
    }
}