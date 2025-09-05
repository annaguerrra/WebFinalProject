using Microsoft.EntityFrameworkCore;
using WebFinalProject.Models;

namespace WebFinalProject.UseCases.Plans.ListAvaliablePlans;

public class ListAvaliablePlansUseCase(WebFinalProjectDbContext ctx)
{
    async Task<Result<ListAvaliablePlansResponse>> Do(ListAvaliablePlansRequest request)
    {
        var plan = await ctx.Plans
            .Select(p => p.Name)
            .Where(p => p.ID == request.PlanID)
            .ToListAsync();

        if (plan is null)
            return Result<ListAvaliablePlansResponse>.BadRequest("There is no registered plan!");

        return Result<ListAvaliablePlansResponse>.Ok(plan);
    }
}
