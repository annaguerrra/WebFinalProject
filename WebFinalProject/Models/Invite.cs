namespace WebFinalProject.Models;

public class Invite
{
    public Guid ID { get; set; }
    public Guid UserID { get; set; }
    public Guid RoomID { get; set; }
    public Guid RoleID { get; set; }
    public Role Role{ get; set; }
    public User User { get; set; }
    public Room Room { get; set; }
}