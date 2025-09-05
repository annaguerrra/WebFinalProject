using WebFinalProject.Models;

namespace WebFinalProject.UseCases.Invites.AnswerInvite;

public record AnswerInviteRequest(
    Guid RoomID,
    Guid UserID,
    int RoleID,
    ICollection<Invite> Invite
);

