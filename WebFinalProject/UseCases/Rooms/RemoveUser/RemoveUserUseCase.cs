using System.Formats.Tar;
using System.IO.Compression;
using System.Security.AccessControl;
using Microsoft.EntityFrameworkCore;
using WebFinalProject.Models;
namespace WebFinalProject.UseCases.Rooms.RemoveUser;

public class RemoveUserUsecase(WebFinalProjectDbContext ctx)
{
    async Task<Result<RemoveUserResponse>> Do(RemoveUserRequest request)
    {

        var admin = await ctx.Accesses.FindAsync(request.AdministratorID);
        var target = await ctx.Accesses.FindAsync(request.MemberID);

        var adminRole = admin.RoleID;
        var targetRole = target.RoleID;

        if (adminRole != 4 || adminRole != 3 && targetRole == 4 || targetRole == 3)
            return Result<RemoveUserResponse>.BadRequest("You don't have permission");
        
        ctx.Accesses.Remove(target);
        await ctx.SaveChangesAsync();
        return Result<RemoveUserResponse>.Ok(null); 
    } 
}
