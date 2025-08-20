namespace WebFinalProject.UseCases.Invites.AcceptInvite;

public record AcceptRequest(
    Guid RoomID,
    Guid UserID
);

