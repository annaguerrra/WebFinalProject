namespace WebFinalProject.Models;

public class Room
{
    public Guid ID { get; set; }
    public string Name { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int AccessID { get; set; }
    public Access Access { get; set; }
    public int UserID { get; set; }
    public User User { get; set; }
    public int PixelID { get; set; }
    public Pixel Pixel { get; set; }

    public ICollection<User> Users { get; set; } = [];
    public ICollection<Access> Accesses { get; set; } = [];
    public ICollection<Pixel> Pixels { get; set; } = [];

    public ICollection<Invite> Invites { get; set; } = [];

}