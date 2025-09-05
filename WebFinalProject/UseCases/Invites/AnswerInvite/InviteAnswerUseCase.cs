using Microsoft.EntityFrameworkCore;
using WebFinalProject.Models;
namespace WebFinalProject.UseCases.Invites.AnswerInvite;

public class AcceptUseCase(
    WebFinalProjectDbContext ctx)
{
    public async Task<Result<AnswerInviteResponse>> Do(AnswerInviteRequest payload)
    {
        var invite = await ctx.Invites.FindAsync(payload.InviteId);

        if (invite is null)
            return Result<AnswerInviteResponse>.BadRequest("Invite not found");

        if (invite.UserID != payload.UserId)
            return Result<AnswerInviteResponse>.BadRequest("Missing permission");

        bool accept = payload.Accepted;

        if (!accept)
        {
            ctx.Invites.Remove(invite);
            await ctx.SaveChangesAsync();
            return Result<AnswerInviteResponse>.Ok(new ());
        }
            ctx.Plans.ToListAsync();
        var role = await ctx.Roles
            .FirstOrDefaultAsync(r => r.Name == "Audience");

        var access = new Access {
            UserID = invite.UserID,
            RoomID = invite.RoomID,
            RoleID = role.ID
        };

        ctx.Accesses.Add(access);
        await ctx.SaveChangesAsync();

        return Result<AnswerInviteResponse>.Ok(new ());
    }
}