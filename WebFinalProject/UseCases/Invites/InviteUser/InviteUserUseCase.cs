using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using WebFinalProject.Models;
using WebFinalProject.Services.RolesServices;

namespace WebFinalProject.UseCases.Invites.InviteUser;
public class InviteUserUseCase(WebFinalProjectDbContext ctx)
{
    public async Task<Result<InviteUserResponse>> Do(InviteUserRequest payload)
    {
        var receiver = await ctx.Users
            .Include(u => u.Invites)
            .Where(i => i.ID == payload.ReceiverID)
            .FirstOrDefaultAsync();

        if (receiver is null)
            return Result<InviteUserResponse>.BadRequest("User not found");
    
        var invite = new Invite
        {
            RoomID = payload.RoomID,
            UserID = payload.ReceiverID,
            RoleID = payload.RoleID
        };

        if (invite is null)
            return Result<InviteUserResponse>.BadRequest("Invite not found");

        receiver.Invites.Add(invite);
        ctx.Invites.Add(invite);

        await ctx.SaveChangesAsync();        
        
        return Result<InviteUserResponse>.Ok(new());
    }
    
    
}