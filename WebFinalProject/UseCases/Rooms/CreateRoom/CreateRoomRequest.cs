namespace WebFinalProject.UseCases.Rooms.CreateRoom;

public record CreateRoomRequest(
    Guid UserID,
    int Width,
    int Height
);