namespace WebFinalProject.UseCases.Rooms.CreateRoom;

public record CreateRoomRequest(
    Guid UserID,
    string Name,
    int Width,
    int Height
);