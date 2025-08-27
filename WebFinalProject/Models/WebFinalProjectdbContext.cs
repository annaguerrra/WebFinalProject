using Microsoft.EntityFrameworkCore;
namespace WebFinalProject.Models;

public class WebFinalProjectDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Room> Rooms => Set<Room>();
    public DbSet<Role> Roles => Set<Role>();
    public DbSet<Access> Accesses => Set<Access>();
    public DbSet<Plan> Plans => Set<Plan>();
    public DbSet<GiftCard> GiftCards => Set<GiftCard>();
    public DbSet<Pixel> Pixels => Set<Pixel>();
    public DbSet<Invite> Invites => Set<Invite>();

    protected override void OnModelCreating(ModelBuilder model)
    {
        model.Entity<Plan>()
            .HasMany(p => p.GiftCards)
            .WithOne(g => g.Plan)
            .HasForeignKey(p => p.PlanID)
            .OnDelete(DeleteBehavior.NoAction);

        model.Entity<Access>()
            .HasOne(a => a.Role)
            .WithMany(r => r.Accesses)
            .HasForeignKey(r => r.RoleID)
            .OnDelete(DeleteBehavior.NoAction);

        model.Entity<Access>()
            .HasOne(a => a.Room)
            .WithMany(r => r.Accesses)
            .HasForeignKey(a => a.RoomID)
            .OnDelete(DeleteBehavior.NoAction);

        model.Entity<Access>()
            .HasOne(a => a.User)
            .WithMany(u => u.Accesses)
            .HasForeignKey(a => a.UserID)
            .OnDelete(DeleteBehavior.NoAction);

        model.Entity<Pixel>()
           .HasOne(p => p.Room)
           .WithMany(r => r.Pixels)
           .HasForeignKey(p => p.RoomID)
           .OnDelete(DeleteBehavior.NoAction);

        model.Entity<Pixel>()
            .HasOne(p => p.User)
            .WithMany(u => u.Pixels)
            .HasForeignKey(p => p.UserID)
            .OnDelete(DeleteBehavior.NoAction);

        model.Entity<Invite>()
            .HasOne(i => i.Room)
            .WithMany(r => r.Invites)
            .HasForeignKey(i => i.RoomID)
            .OnDelete(DeleteBehavior.NoAction);

        model.Entity<Room>()
            .HasOne(r => r.User)
            .WithMany(u => u.Rooms)
            .HasForeignKey(r => r.UserID)
            .OnDelete(DeleteBehavior.NoAction);

        model.Entity<Invite>()
            .HasOne(u => u.User)
            .WithMany(i => i.Invites)
            .HasForeignKey(u => u.UserID)
            .OnDelete(DeleteBehavior.NoAction);

        model.Entity<User>()
            .HasOne(u => u.Plan)
            .WithMany(p => p.Users)
            .HasForeignKey(u => u.PlanID)
            .OnDelete(DeleteBehavior.NoAction);

        model.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();

        model.Entity<User>()
            .HasIndex(u => u.Username)
            .IsUnique();
    }
}