using Microsoft.EntityFrameworkCore;
using WebFinalProject.Models;
namespace WebFinalProject.UseCases.Rooms.DeleteRoom;

public class DeleteRoomUsecase(WebFinalProjectDbContext ctx)
{
    async Task<Result<DeleteRoomResponse>> Do(DeleteRoomRequest payload)
    {
        if (payload.RoleID != 4)
            return Result<DeleteRoomResponse>.BadRequest("You don't have permission");

        var room = await ctx.Rooms
            .Include(a => a.Accesses)
            .Where(r => r.UserID == payload.UserID && r.ID == payload.RoomID && r == r.Accesses.Select(a => a.RoleID == 4))
            .FirstAsync();

        if (room is null)
            return Result<DeleteRoomResponse>.BadRequest("Room not found");

        ctx.Rooms.Remove(room);
        await ctx.SaveChangesAsync();
        return Result<DeleteRoomResponse>.Ok(new ());
    }
}

