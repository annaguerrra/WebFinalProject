using Microsoft.EntityFrameworkCore;
using WebFinalProject.Models;

namespace WebFinalProject.UseCases.Users.ViewProfile;

public class ViewProfileUseCase(
    WebFinalProjectDbContext ctx
)
{
    public async Task<Result<ViewProfileResponse>> Do(ViewProfileRequest payload)
    {
        var profile = await ctx.Users.FirstOrDefaultAsync(
         p => p.Username == payload.Username
        );

        if (profile is null)
            return Result<ViewProfileResponse>.BadRequest($"User '{profile.Username}' not found");

        var response = new ViewProfileResponse(
            profile.Username,
            profile.Bio,
            profile.Image
        );

        return Result<ViewProfileResponse>.Ok(response);
    }
}