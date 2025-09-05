using WebFinalProject.Models;
using WebFinalProject.Services.RolesServices;
namespace WebFinalProject.UseCases.Invites.AcceptInvite;

public class AcceptUseCase(
    WebFinalProjectDbContext ctx,
    RolesServices role
)
{
    public async Task<Result<AcceptResponse>> Do(AcceptRequest payload)
    {
        var access = new Access
        {
            RoomID = payload.RoomID,
            UserID = payload.UserID,
            RoleID = payload.RoleID
        };
        
        ctx.Accesses.Add(access);
        await ctx.SaveChangesAsync();

        return Result<AcceptResponse>.Ok(null);
    }
}