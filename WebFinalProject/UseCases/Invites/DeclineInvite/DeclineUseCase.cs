using Microsoft.EntityFrameworkCore;
using WebFinalProject.Models;
using WebFinalProject.Services.IRolesServices;
namespace WebFinalProject.UseCases.Invites.DeclineInvite;

public class DeclineInviteUseCase(
    WebFinalProjectDbContext ctx,
    IRolesServices role
)
{
    public async Task<Result<DeclineResponse>> Do(DeclineRequest payload)
    {
        var user = new User();
        if (payload.RoomID == payload.) {
            ctx.Invites.FirstOrDefaultAsync()
        }
        
        return Result<DeclineResponse>.Ok(null);
    }
}