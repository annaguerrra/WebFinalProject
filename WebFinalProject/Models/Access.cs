namespace WebFinalProject.Models;

public class Access
{
    public Guid ID { get; set; }
    public string Name { get; set; }
    public Guid RoomID { get; set; }
    public Guid UserID{ get; set; }
    public Guid RoleID { get; set; } 
    public Room Room { get; set; }
    public User User{ get; set; }
    public Role Role { get; set; }
}