using WebFinalProject.Models;
using WebFinalProject.UseCases.Rooms.DeleteRoom;
using 
namespace WebFinalProject.UseCases.Rooms.DeleteRoom;

public class DeleteRoomUsecase(WebFinalProjectDbContext ctx)
{
    async Task<Result<DeleteRoomResponse>> Do(DeleteRoomRequest request)
    {
        var access = ctx.Accesses.Where(a => a.RoomID == request.RoomID && a.UserID == request.UserID).FirstOrDefault();
        if (access is null)
            return Result<DeleteRoomResponse>.BadRequest();

        if (access.RoleID != 4)
            return Result<DeleteRoomResponse>.BadRequest("You don't have permission!");

        ctx.Rooms.Remove(access.RoomID);
        await ctx.SaveChangesAsync();
        return Result<DeleteRoomResponse>.Ok();
    }
}
