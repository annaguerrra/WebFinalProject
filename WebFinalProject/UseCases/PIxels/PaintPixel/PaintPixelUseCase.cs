using Microsoft.EntityFrameworkCore;
using WebFinalProject.Models;

namespace WebFinalProject.UseCases.PaintPixel;

public class PaintUseCase(WebFinalProjectDbContext ctx)
{
    public async Task<Result<PaintPixel>> Do(PaintPixelRequest request)
    {
        var room = await ctx.Rooms.FindAsync(request.RoomID);
        if (room is null)
            return Result<PaintPixel>.BadRequest("Room not found.");   

        var user = await ctx.Users.FindAsync(request.UserID);
        if (user is null)
            return Result<PaintPixel>.BadRequest("User not found.");

        var pixel = await ctx.Pixels
            .FirstOrDefaultAsync(p => p.RoomID == request.RoomID && p.X == request.x && p.Y == request.y);

        if (pixel is null)
        {
            pixel = new Pixel
            {
                RoomID = request.RoomID,
                UserID = request.UserID,
                X = request.x,
                Y = request.y,
                R = request.R,
                G = request.G,
                B = request.B
            };
            ctx.Pixels.Add(pixel);
        }
        else
        {
            pixel.R = request.R;
            pixel.G = request.G;
            pixel.B = request.B;
            pixel.UserID = request.UserID;
            ctx.Pixels.Update(pixel);
        }

        room.Pixels.Add(pixel);

        await ctx.SaveChangesAsync();
        return Result<PaintPixel>.Ok(new());

        
    }
}
  