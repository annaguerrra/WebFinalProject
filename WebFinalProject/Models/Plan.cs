namespace WebFinalProject.Models;

public class Plan
{
    public Guid ID { get; set; }
    public string Name { get; set; }
    public ICollection<User> Users { get; set; } = [];
    public ICollection<GiftCard> GiftCards { get; set; } = [];
}