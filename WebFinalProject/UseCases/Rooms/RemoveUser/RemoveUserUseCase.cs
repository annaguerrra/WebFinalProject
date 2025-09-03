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
        
        




        // var admin = await ctx.Rooms
        //     .Include(r => r.Users)
        //         .ThenInclude(u => u.Accesses)
        //     .Where(a => a.ID == request.RoomID)
        //     .Select(r => r.UserID == request.AdministratorID) 
        //     .FirstOrDefaultAsync();

        // if (admin)

        //     var role = await ctx.Roles
        //         .FindAsync(request.);

        // var room = await ctx.Rooms
        //     .Include(r => r.Accesses)
        //     .Where(a => a.UserID == request.)
        //     .FirstOrDefaultAsync(r => r.ID == request.RoomID);


        // if (room.User.Username is null)
        //     return Result<RemoveUserResponse>.BadRequest("User not found");

        // if(room.)
    } 
}
