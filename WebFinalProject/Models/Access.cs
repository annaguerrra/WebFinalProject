namespace WebFinalProject.Models;

public class Access
{
    public Guid ID { get; set; }
    public string Name { get; set; }
    public int RoomID { get; set; }
    public int UserID{ get; set; }
    public int RoleID { get; set; } 
    public Room Room { get; set; }
    public User User{ get; set; }
    public Role Role { get; set; }
    public ICollection<User> Users { get; set; } = [];
    public ICollection<Room> Rooms { get; set; } = [];

}