namespace WebFinalProject.UseCases.Invites.InviteUser;

public record InviteUserRequest(
    Guid ReceiverID,
    string Username,
    Guid RoomID,
    Guid RoleID
);