namespace WebFinalProject.Models;

public class User
{
    public Guid ID { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Image { get; set; }
    public DateTime ExpirationDate { get; set; }
    public string Bio { get; set; }

    public Guid PlanID { get; set; }
    public Plan Plan { get; set; }

    public ICollection<Pixel> Pixels { get; set; } = [];
    public ICollection<Room> Rooms { get; set; } = [];
    public ICollection<Access> Accesses { get; set; } = [];
    public ICollection<Invite> Invites { get; set; } = [];

}