using WebFinalProject.Models;
using WebFinalProject.UseCases.Rooms.CreateRoom;
namespace WebFinalProject.UseCases.Plans.RedeemPlanCode;

public class RedeemPlanCodeUseCase(WebFinalProjectDbContext ctx)
{
    async Task<Result<RedeemPlanCodeResponse>> Do(RedeemPlanCodeRequest request)
    {
        var giftcard = await ctx.GiftCards.FindAsync(request.GiftCardID);
        var user = await ctx.Users.FindAsync(request.UserID);

        if (giftcard is null)
            return Result<RedeemPlanCodeResponse>.BadRequest("GiftCard not found");

        ctx.GiftCards.Remove(giftcard);
        ctx.user.PlanID(giftcard.PlanID);

        return Result<RedeemPlanCodeResponse>.Ok(new ());
    }
}