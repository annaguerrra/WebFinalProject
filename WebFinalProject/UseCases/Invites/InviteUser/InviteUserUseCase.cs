using WebFinalProject.Models;
using WebFinalProject.Services.IRolesServices;

using WebFinalProject.Services.RolesServices;

namespace WebFinalProject.UseCases.Invites.InviteUser;

public class InviteUserUseCase(WebFinalProjectDbContext ctx,
    IRolesServices rolesServices
)
{
    async Task<Result<InviteUserResponse>> Do(InviteUserRequest payload)
    {
        var invite = new Invite (
            
        )
    }

}