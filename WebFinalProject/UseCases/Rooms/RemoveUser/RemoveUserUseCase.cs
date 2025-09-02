using WebFinalProject.Models;
namespace WebFinalProject.UseCases.Rooms.RemoveUser;

public class RemoveUserUsecase(WebFinalProjectDbContext ctx)
{
    async Task<Result<RemoveUserResponse>> Do(RemoveUserRequest request)
    {
        // var access = ctx.Accesses.Where(
        //     a => a.RoomID == request.RoomID &&
        //     a => a.U == 
        // )
        // dotnet ef migrations add <Oto nome> 
    // dotnet ef database update
    } 
}
