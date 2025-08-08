namespace WebFinalProject.Models;

public class Role
{
    public Guid ID { get; set; }
    public string Name { get; set; }
    public ICollection<Access> Accesses { get; set; } = [];
}