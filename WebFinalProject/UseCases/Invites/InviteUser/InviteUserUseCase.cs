namespace WebFinalProject.UseCases.Invites.InviteUser;

public class InviteUserUseCase
{
    public async Task<Result<InviteUserResponse>> Do(InviteUserRequest payload)
       if (role.RoleDefinition() == 3 || role.RoleDefinition() == 4)
        {
            ctx.Accesses.Add(access);
            await ctx.SaveChangesAsync();
            return Result<AcceptResponse>.Ok(null);     
        }
        return Result<AcceptResponse>.BadRequest("");
}