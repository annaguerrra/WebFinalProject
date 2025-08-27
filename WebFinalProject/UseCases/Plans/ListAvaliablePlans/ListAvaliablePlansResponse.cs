using WebFinalProject.Models;

namespace WebFinalProject.UseCases.Plans.ListAvaliablePlans;

public record ListAvaliablePlansResponse(
    ICollection<Plan> Plans
);