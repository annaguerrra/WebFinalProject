using System.ComponentModel.DataAnnotations;
using WebFinalProject.UseCases.Rooms;
namespace WebFinalProject.UseCases.PaintPixel;
public record PaintRequest {
    [Required]
    int x;
    int y;
    int R;
    int G;
    int B;
    Guid RoomID;
}