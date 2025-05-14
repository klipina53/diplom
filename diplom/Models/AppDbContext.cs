using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace diplom.Models
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<UserMembership> UserMemberships { get; set; }
        public DbSet<TrainingSession> TrainingSessions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Настройка отношений и начальных данных
            modelBuilder.Entity<MembershipType>().HasData(
                new MembershipType
                {
                    Id = 1,
                    TypeName = "individual",
                    Description = "Индивидуальные тренировки",
                    Price = 5000.00m,
                    DurationDays = 30,
                    VisitsCount = 8,
                    IsPersonalTraining = true
                },
                new MembershipType
                {
                    Id = 2,
                    TypeName = "grouped",
                    Description = "Групповые тренировки",
                    Price = 3000.00m,
                    DurationDays = 30,
                    VisitsCount = 12,
                    IsPersonalTraining = false
                },
                new MembershipType
                {
                    Id = 3,
                    TypeName = "without_trainer",
                    Description = "Без тренера (месяц)",
                    Price = 2000.00m,
                    DurationDays = 30,
                    VisitsCount = null,
                    IsPersonalTraining = false
                }
            );
        }
    }
}