namespace WebFinalProject.Models;

public class GiftCard
{
    public Guid ID { get; set; }
    public string Name { get; set; }
    public DateTime Duration { get; set; }
    public Guid PlanID { get; set; }
    public Plan Plan { get; set; }
}