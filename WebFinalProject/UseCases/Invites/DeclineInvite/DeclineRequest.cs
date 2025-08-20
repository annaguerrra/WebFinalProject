namespace WebFinalProject.UseCases.Invites.DeclineInvite;

public record DeclineRequest(
    Guid RoomID,
    Guid UserID
);