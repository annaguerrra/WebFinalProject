using WebFinalProject.Models;
namespace WebFinalProject.UseCases.Rooms.ViewRoom;

public class ViewRoomUseCase(WebFinalProjectDbContext ctx)
{
    async Task<Result<ViewRoomResponse>> Do(ViewRoomRequest request)
    {
        var room = await ctx.Rooms.FindAsync(request.RoomID);
        var user = await ctx.Accesses.FindAsync(request.UserID);

        if(user.RoomID != room.ID)
            return Result<ViewRoomResponse>.BadRequest("Forbidden");
        
        var response = new ViewRoomResponse(
            room.Name,
            room.Width,
            room.Height
        );

        return Result<ViewRoomResponse>.Ok(response);
    } 
}

