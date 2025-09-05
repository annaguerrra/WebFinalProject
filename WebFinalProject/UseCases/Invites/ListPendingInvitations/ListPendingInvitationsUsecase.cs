using Microsoft.EntityFrameworkCore;
using WebFinalProject.Models;

namespace WebFinalProject.UseCases.Invites.ListPendingInvitations;

public class ListPendingInvitationsUsecase(WebFinalProjectDbContext ctx)
{
    public async Task<Result<ListPendingInvitationsResponse>> Do(ListPendingInvitationsRequest request)
    {
        var user = await ctx.Users
            .FirstOrDefaultAsync(u => u.Username == request.Username);

        if (user is null)
            return Result<ListPendingInvitationsResponse>.BadRequest("User not found.");
        

        var invites = await ctx.Invites
            .Where(i => i.UserID == user.ID)
            .Include(i => i.Room) 

            .ToListAsync();



        var response = new ListPendingInvitationsResponse(invites);

        return Result<ListPendingInvitationsResponse>.Ok(response);
    }
}