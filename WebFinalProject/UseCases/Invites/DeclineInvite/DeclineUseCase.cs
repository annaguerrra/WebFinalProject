using Microsoft.EntityFrameworkCore;
using WebFinalProject.Models;
using WebFinalProject.Services.IRolesServices;
namespace WebFinalProject.UseCases.Invites.DeclineInvite;

public class DeclineInviteUseCase(
    WebFinalProjectDbContext ctx,
    IRolesServices role
)
{
    public async Task<Result<DeclineResponse>> Do(DeclineRequest request)
    {
        var room = await ctx.Rooms.FindAsync(request.RoomID);
        var user = await ctx.Users.FindAsync(request.UserID);
        var invite = await ctx.Users.Invites.FindAsync(request.InviteID);

        if(!user.Invites.Contains(request.InviteID))
            return Result<DeclineInvite>.BadRequest("Invite doesn't exist");

        ctx.Users.Invites.Remove(invite);
        
        return Result<DeclineResponse>.Ok(null);
    }
}