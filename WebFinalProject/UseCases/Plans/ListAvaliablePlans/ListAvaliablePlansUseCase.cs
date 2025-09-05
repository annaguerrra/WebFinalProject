using WebFinalProject.Models;
using WebFinalProject.UseCases.Rooms.ListRoomUsers;

namespace WebFinalProject.UseCases.Plans.ListAvaliablePlans;

public class ListAvaliablePlansUsecase(WebFinalProjectDbContext ctx)
{
    async Task<Result<ListAvaliablePlansResponse>> Do(ListAvaliablePlansRequest request)
    {
        var plan = await ctx.Plans.ToListAsync();

        if (!plan)
            return Result<ListRoomUsersResponse>.BadRequest("There is no registered plan");

        return Result<ListAvaliablePlansResponse>.Ok(plan);
    }
}