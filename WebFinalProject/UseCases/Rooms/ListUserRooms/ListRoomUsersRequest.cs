namespace WebFinalProject.UseCases.Rooms.ListRoomUsers;

public record ListRoomUsersRequest(
    Guid RoomID,
    Guid UserID,
    int RoleID
);