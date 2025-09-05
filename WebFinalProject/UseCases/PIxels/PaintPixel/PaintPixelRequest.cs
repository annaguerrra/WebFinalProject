using System.ComponentModel.DataAnnotations;
using WebFinalProject.UseCases.Rooms;
namespace WebFinalProject.UseCases.PaintPixel;

public record PaintPixelRequest
{
    [Required]
    public int x { get; set; }
    public int y { get; set; }
    public int R { get; set; }
    public int G { get; set; }
    public int B { get; set; }
    public Guid RoomID { get; set; }
    public Guid UserID { get; set; }
}