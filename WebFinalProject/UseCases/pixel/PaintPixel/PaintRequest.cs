namespace WebFinalProject.UseCases.Invite.PaintPixel;

public record PaintRequest(
    
    int x,
    int y,
    int R,
    int G,
    int B,
    Guid RoomID
);