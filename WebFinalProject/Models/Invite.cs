namespace WebFinalProject.Models;

public class Invite
{
    public Guid ID { get; set; }
    public Guid UserID { get; set; }
    public Guid RoomID { get; set; }
    public User User { get; set; }
    public Room Room { get; set; }
}