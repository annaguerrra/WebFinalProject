namespace WebFinalProject.UseCases.Invites.AnswerInvite;

public record AnswerInviteRequest(
    Guid UserId,
    Guid InviteId,
    bool Accepted
);