namespace WebFinalProject.Models;

public class Invite
{
    public Guid ID { get; set; }
    public int UserID { get; set; }
    public int RoomID { get; set; }

    public User User { get; set; }
    public Room Room { get; set; }

    public ICollection<User> Users{ get; set; } = [];
}