using Microsoft.EntityFrameworkCore;

namespace WebFinalProject.Models;

public class WebFinalProjectDbContext(DbContextOptions opt) : DbContext(opt)
{
    public DbSet<User> Users = Set<User>();
    public DbSet<Room> Rooms = Set<Room>();
    public DbSet<Role> Roles = Set<Role>();
    public DbSet<Access> Accesses = Set<Access>();
    public DbSet<Plan> Plans = Set<Plan>();
    public DbSet<GiftCard> GiftCards = Set<GiftCard>();
    public DbSet<Pixel> Pixels = Set<Pixel>();
    public DbSet<Invite> Invites = Set<Invite>();

    protected override void OnModelCreating(ModelBuilder model)
    {
        model.Entity<User>()
            
    }
}