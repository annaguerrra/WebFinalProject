using Microsoft.EntityFrameworkCore;

namespace WebFinalProject.Models;

public class WebFinalProjectDbContext(DbContextOptions opt) : DbContext(opt)
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
        model.Entity<User>()
            .HasOne(u => u.Plan)
            .WithMany(p => p.Users)
            .OnDelete(DeleteBehavior.NoAction);

        model.Entity<GiftCard>()
            .HasOne(p => p.Plan)
            .WithMany(g => g.GiftCards)
            .HasForeignKey(k => k.PlanID)
            .OnDelete(DeleteBehavior.NoAction);

        model.Entity<Access>()
            .HasOne(a => a.Role)
            .WithMany(u => u.Accesses)
            .OnDelete(DeleteBehavior.NoAction);

        model.Entity<Access>()
            .HasOne(a => a.Room)
            .WithMany(r => r.Accesses)
            .OnDelete(DeleteBehavior.NoAction);

        model.Entity<Access>()
            .HasOne(a => a.User)
            .WithMany(u => u.Accesses)
            .OnDelete(DeleteBehavior.NoAction);

        model.Entity<Room>()
            .HasMany(r => r.Pixels)
            .WithOne(p => p.Room)
            .OnDelete(DeleteBehavior.NoAction);

        model.Entity<Invite>()
            .HasMany(i => i.Users)
            .WithOne(u => u.Invite)
            .OnDelete(DeleteBehavior.NoAction);

        model.Entity<Invite>()
            .HasOne(i => i.Room)
            .WithMany(r => r.Invites)
            .OnDelete(DeleteBehavior.NoAction);

    }

}