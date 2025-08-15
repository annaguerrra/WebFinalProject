namespace WebFinalProject.Models;

public class Pixel
{
    public Guid ID { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public int R { get; set; }
    public int G { get; set; }
    public int B { get; set; }

    public Guid UserID { get; set; }
    public User User { get; set; }

    public Guid RoomID { get; set; }
    public Room Room { get; set; }
}