namespace WebFinalProject.UseCases.Invite.AcceptInvite;

public record AcceptRequest(
    Guid RoomID,
    Guid UserID
);

