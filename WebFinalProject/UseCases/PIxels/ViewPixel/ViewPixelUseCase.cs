using Microsoft.EntityFrameworkCore;
using WebFinalProject.Models;
using WebFinalProject.UseCases.Pixels;

namespace WebFinalProject.UseCases.Pixels.ViewPixel;

public class ViewPixelUseCase(WebFinalProjectDbContext ctx)
{
    public async Task<Result<ViewPixelResponse>> Do(ViewPixelRequest request)
    {
        var room = await ctx.Rooms.FindAsync(request.RoomID);

        if (room is null)
            return Result<ViewPixelResponse>.BadRequest("Room doesn't exist!");
        
        var pixels = await ctx.Pixels.Where(p => p.RoomID == request.RoomID).ToListAsync();
        var response = new ViewPixelResponse(pixels);

        return Result<ViewPixelResponse>.Ok(response);
    }
}