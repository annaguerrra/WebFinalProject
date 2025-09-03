using WebFinalProject.Models;
namespace WebFinalProject.UseCases.Rooms.ListUserRooms;

public record ListUserRoomsResponse(
    string Title,
    IEnumerable<Member> MemberData
);

public record Member
(
    Guid UserID,
    string Username,
    Guid RoleID,
    string RoleTitle
);
