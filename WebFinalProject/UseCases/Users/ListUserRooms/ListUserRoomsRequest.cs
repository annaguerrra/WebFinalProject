namespace WebFinalProject.UseCases.Rooms.ListUserRooms;

public record ListUserRoomsRequest(
    Guid RoomID,
    Guid UserID,
    int RoleID
);