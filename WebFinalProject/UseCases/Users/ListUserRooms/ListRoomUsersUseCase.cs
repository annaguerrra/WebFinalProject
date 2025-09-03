using WebFinalProject.Models;
using Microsoft.EntityFrameworkCore;
namespace WebFinalProject.UseCases.Rooms.ListRoomUsers;

public class ListRoomUsersUseCase(WebFinalProjectDbContext ctx)
{
    public async Task<Result<ListRoomUsersResponse>> Do(ListRoomUsersRequest request)
    {
        var room = await ctx.Rooms
            .Include(r => r.Users)
                .ThenInclude(u => u.Accesses)
                    .ThenInclude(a => a.Role)
            .FirstOrDefaultAsync(r => r.ID == request.RoomID);
 
        if (room is null)
            return Result<ListRoomUsersResponse>.BadRequest("Room doesn't exists");

        if (room.UserID != request.UserID)
            return Result<ListRoomUsersResponse>.BadRequest("Forbiden");

        var role = await ctx.Roles
            .FindAsync(request.RoleID);

        var response = new ListRoomUsersResponse(
            room.Name,
            from u in room.Users
            select new Member
            {
                Nickname = u.Username,
                RoleTitle = role.Name
            });

        return Result<ListRoomUsersResponse>.Ok(response);
    }    
}

