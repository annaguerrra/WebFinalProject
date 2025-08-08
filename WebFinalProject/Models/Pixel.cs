namespace WebFinalProject.Models;

public class Pixel
{
    public GUID ID { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public int R { get; set; }
    public int G { get; set; }
    public int B { get; set; }
    public Room RoomID { get; set; }
}