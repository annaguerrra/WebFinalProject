using WebFinalProject.Models;

namespace WebFinalProject.UseCases.Invites.ListPendingInvitations;

public record ListPendingInvitationsRequest(
    string Username
);
