using Microsoft.EntityFrameworkCore;
using WebFinalProject.Models;
namespace WebFinalProject.UseCases.Invites.AnswerInvite;

public class AcceptUseCase(
    WebFinalProjectDbContext ctx)
{
    public async Task<Result<AnswerInviteResponse>> Do(AnswerInviteRequest payload)
    {
        var invite = await ctx.Users
            .Include(u => u.Invites)
            .Include(a => a.Accesses)
            .Where(i => i.Invites == payload.Invite.Select(i => i.ID))
            .FirstOrDefaultAsync();
        
        var access = await ctx.Accesses
            .Where(a => a)

        if (invite is null)
            return Result<AnswerInviteResponse>.BadRequest("Invite not found");

        bool accept = true;

        if (!accept)
        {
            ctx.Users.Remove(invite);
            await ctx.SaveChangesAsync();
        }
        ctx.Users.Add(invite);
        await ctx.SaveChangesAsync();

        return Result<AnswerInviteResponse>.Ok(new ());
    }
}