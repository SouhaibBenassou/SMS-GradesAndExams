using Domain;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<SessionsExam> SessionsExams { get; set; }
        public DbSet<Supervisor> Supervisors { get; set; }
        public DbSet<Room> Rooms { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<Exam>()
                .HasOne(e => e.SessionsExam)
                .WithOne(e => e.Exam)
                .HasForeignKey<Exam>(e => e.SessionsExamId);

            modelBuilder.Entity<SessionsExam>()
                .HasOne(e => e.Room)
                .WithMany(e => e.SessionsExams)
                .HasForeignKey(e => e.IdRoom);
            modelBuilder.Entity<SessionsExam>()
                .HasOne(e => e.Supervisor)
                .WithMany(e => e.Sessions)
                .HasForeignKey(e => e.IdSupervisor);

        }
    }
}
