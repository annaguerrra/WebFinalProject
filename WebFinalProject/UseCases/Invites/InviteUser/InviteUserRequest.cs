namespace WebFinalProject.UseCases.Invites.InviteUser;

public record InviteUserRequest(
    Guid UserID,
    Guid RoomID,
    Guid RoleID,
    Guid AccessID
);