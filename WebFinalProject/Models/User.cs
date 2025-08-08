namespace WebFinalProject.Models;

public class User
{
    public Guid ID { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Image { get; set; }
    public DateTime ExpirationDate { get; set; }
    public string Bio { get; set; }
    public int PlanID { get; set; }
    public int RoomID { get; set; }
    public Plan Plan { get; set; }
    public Room Room { get; set; }

    public int InviteID{ get; set; }
    public Invite Invite{ get; set; }

    public int AccessID { get; set; }
    public Access Access { get; set; }

    public ICollection<Room> Rooms { get; set; } = [];
    public ICollection<Access> Accesses { get; set; } = [];

}