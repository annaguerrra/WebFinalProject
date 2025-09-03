namespace WebFinalProject.UseCases.Rooms.DeleteRoom;

public record DeleteRoomRequest(
    Guid RoomID,
    Guid UserID,
    int RoleID
);