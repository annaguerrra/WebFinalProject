namespace WebFinalProject.Models;

public class User
{
    public GUID ID { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Image { get; set; }
    public DateTime ExpirationDate { get; set; }
    public string Bio { get; set; }
    public Plan PlanID { get; set; }
}