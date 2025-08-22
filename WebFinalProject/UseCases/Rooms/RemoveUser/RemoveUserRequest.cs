namespace WebFinalProject.UseCases.Rooms.RemoveUser;

public record RemoveUserRequest(
    Guid RequesterUserID, 
    Guid RoomID,
    Guid TargetUserID 
);