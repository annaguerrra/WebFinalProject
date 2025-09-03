using WebFinalProject.Models;
using Microsoft.EntityFrameworkCore;
using 
namespace WebFinalProject.UseCases.Rooms.ListUserRooms;

public class ListRoomUsersUseCase(WebFinalProjectDbContext ctx)
{
    async Task<Result<ListUserRoomsResponse>> Do(ListUserRoomsRequest request)
    {
        var room = await ctx.Rooms
            .Include(r => r.Users)
                .ThenInclude(u => u.Accesses)
                    .ThenInclude(a => a.Role)
            .FirstOrDefaultAsync(r => r.ID == request.RoomID);


        if (room is null)
            return Result<ListUserRoomsResponse>.BadRequest("Room doesn't exists");

        if (room.UserID != request.UserID)
            return Result<ListUserRoomsResponse>.BadRequest("Forbiden");

        var response = new ListUserRoomsResponse(
            room.Name,
            from u in room.Users
            select new Member
            {
                Username = u.Username,
                
            }
        );
        
    }    
    
}

