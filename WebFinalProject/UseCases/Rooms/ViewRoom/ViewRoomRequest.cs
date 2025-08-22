namespace WebFinalProject.UseCases.Rooms.ViewRoom;

public record ViewRoomRequest(
    Guid UserID,
    Guid RoomID
);