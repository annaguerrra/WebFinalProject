namespace WebFinalProject.UseCases.Rooms.DeleteRoom;

public record DeleteRoomRequest(
    Guid UserID,
    Guid RoomID

);