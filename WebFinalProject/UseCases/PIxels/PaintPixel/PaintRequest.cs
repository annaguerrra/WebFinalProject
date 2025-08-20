using System.ComponentModel.DataAnnotations;
namespace WebFinalProject.UseCases.Invite.PaintPixel;

public record PaintRequest(
    [Required]
    int x,
    int y,
    int R,
    int G,
    int B,
    Guid RoomID
);