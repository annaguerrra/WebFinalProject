using WebFinalProject.Models;
using Microsoft.EntityFrameworkCore;
namespace WebFinalProject.UseCases.Rooms.ListUserRooms;

public class ListUserRoomsUseCase(WebFinalProjectDbContext ctx)
{
    async Task<Result<ListUserRoomsResponse>> Do(ListUserRoomsRequest request)
    {
        var room = await ctx.Rooms
            .Include(r => r.Users)
                .ThenInclude(u => u.User)
            .Include(r => r.Users)
                .ThenInclude(u => u.Access)
            .FirstOrDefaultAsync(r => r.ID == request.UserID);
    }    
    
}
