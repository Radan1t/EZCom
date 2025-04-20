using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace Infrastructure.Persistence.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ProductVersionType> ProductVersionTypes { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<UserChat> UserChats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<UserDepartment> UserDepartments { get; set; }
        public DbSet<DepartmentChat> DepartmentChats { get; set; }
        public DbSet<CompanyChat> CompanyChats { get; set; }
        public DbSet<Meet> Meets { get; set; }
        public DbSet<MeetUser> MeetUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserChat>()
                .HasKey(uc => new { uc.UserID1, uc.UserID2 });

            modelBuilder.Entity<UserChat>()
                .HasOne(uc => uc.User1)
                .WithMany(u => u.UserChats1)
                .HasForeignKey(uc => uc.UserID1)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserChat>()
                .HasOne(uc => uc.User2)
                .WithMany(u => u.UserChats2)
                .HasForeignKey(uc => uc.UserID2)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserDepartment>()
                .HasKey(ud => new { ud.UserID, ud.DepartmentID });

            modelBuilder.Entity<UserDepartment>()
                .HasOne(ud => ud.User)
                .WithMany(u => u.UserDepartments)
                .HasForeignKey(ud => ud.UserID)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<UserDepartment>()
                .HasOne(ud => ud.Department)
                .WithMany(d => d.UserDepartments)
                .HasForeignKey(ud => ud.DepartmentID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DepartmentChat>()
                .HasKey(dc => new { dc.DepartmentID, dc.ChatID });

            modelBuilder.Entity<DepartmentChat>()
                .HasOne(dc => dc.Department)
                .WithMany(d => d.DepartmentChats)
                .HasForeignKey(dc => dc.DepartmentID)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<DepartmentChat>()
                .HasOne(dc => dc.Chat)
                .WithMany(c => c.DepartmentChats)
                .HasForeignKey(dc => dc.ChatID)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<CompanyChat>()
                .HasKey(cc => new { cc.CompanyID, cc.ChatID });

            modelBuilder.Entity<CompanyChat>()
                .HasOne(cc => cc.Company)
                .WithMany(c => c.CompanyChats)
                .HasForeignKey(cc => cc.CompanyID)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<CompanyChat>()
                .HasOne(cc => cc.Chat)
                .WithMany(c => c.CompanyChats)
                .HasForeignKey(cc => cc.ChatID)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<MeetUser>()
                .HasKey(mu => new { mu.UserID, mu.MeetID });

            modelBuilder.Entity<MeetUser>()
                .HasOne(mu => mu.User)
                .WithMany(u => u.MeetUsers)
                .HasForeignKey(mu => mu.UserID)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<MeetUser>()
                .HasOne(mu => mu.Meet)
                .WithMany(m => m.MeetUsers)
                .HasForeignKey(mu => mu.MeetID)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<Message>()
                .HasOne(m => m.User)
                .WithMany(u => u.Messages)
                .HasForeignKey(m => m.UserID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
