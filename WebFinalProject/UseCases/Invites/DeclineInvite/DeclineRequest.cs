using WebFinalProject.Models;

namespace WebFinalProject.UseCases.Invites.DeclineInvite;

public record DeclineRequest(
    Guid RoomID,
    Guid UserID,
    Guid InviteID
);