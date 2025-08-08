namespace WebFinalProject.Models;

public class Invite
{
    public GUID ID { get; set; }
    public User UserID { get; set; }
    public Room RoomID { get; set; }
}