using WebFinalProject.Models;

namespace WebFinalProject.UseCases.Invites.ListPendingInvitations;

public record ListPendingInvitationsResponse(
    ICollection<Invite> Invites
);