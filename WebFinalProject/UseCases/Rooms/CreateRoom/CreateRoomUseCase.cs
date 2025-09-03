using WebFinalProject.Models;
namespace WebFinalProject.UseCases.Rooms.CreateRoom;

public class CreateRoomUseCase(WebFinalProjectDbContext ctx)
{
    public async Task<Result<CreateRoomResponse>> Do(CreateRoomRequest request)
    {
        var room = new Room
        {
            UserID = request.UserID,
            Name = request.Name,
            Width = request.Width,
            Height = request.Height
        };

        ctx.Add(room);
        await ctx.SaveChangesAsync();
        return Result<CreateRoomResponse>.Ok(new());
    }
}