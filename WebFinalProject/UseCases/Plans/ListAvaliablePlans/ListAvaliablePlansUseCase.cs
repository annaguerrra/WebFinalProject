using WebFinalProject.Models;

namespace WebFinalProject.UseCases.Plans.ListAvaliablePlans;

public class ListAvaliablePlansUsecase(WebFinalProjectDbContext ctx)
{
    async Task<Result<ListAvaliablePlansResponse>> Do(ListAvaliablePlansRequest request)
    {
        
    }
}