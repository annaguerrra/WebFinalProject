using Microsoft.Identity.Client;
using WebFinalProject.Models;
namespace WebFinalProject.UseCases.Rooms.ListRoomUsers;

public record ListRoomUsersResponse(
    string Title,
    IEnumerable<Member> MemberData
);

public record Member
{
    public required string Nickname { get; set; }
    public required string RoleTitle { get; set; }
}
