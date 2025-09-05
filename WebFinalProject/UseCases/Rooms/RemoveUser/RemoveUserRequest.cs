namespace WebFinalProject.UseCases.Rooms.RemoveUser;

public record RemoveUserRequest(
    Guid AdministratorID, 
    Guid RoomID,
    Guid MemberID,
    int RoleID
);