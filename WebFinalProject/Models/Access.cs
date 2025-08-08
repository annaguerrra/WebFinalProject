namespace WebFinalProject.Models;

public class Access
{
    public GUID ID { get; set; }
    public string Name { get; set; }
    public User UserID { get; set; }
    public Room RoomID{ get; set; }
}