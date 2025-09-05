using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using WebFinalProject.Models;
using WebFinalProject.UseCases.Rooms.ListRoomUsers;

namespace WebFinalProject.UseCases.Plans.ListAvaliablePlans;

public class ListAvaliablePlansUsecase(WebFinalProjectDbContext ctx)
{
    async Task<Result<ListAvaliablePlansResponse>> Do(ListAvaliablePlansRequest request)
    {
        var plan = await ctx.Plans
            .Select(p => p.Name == request.Name)
            .ToListAsync();


        if (plan is null)
            return Result<ListAvaliablePlansResponse>.BadRequest("There is no registered plan!");

        return Result<ListAvaliablePlansResponse>.Ok();
    }
}
