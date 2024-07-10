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
            // Supervisor -> Exam
            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Supervisor)
                .WithMany()
                .HasForeignKey(e => e.SupervisorId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            // Exam -> SessionsExam
            modelBuilder.Entity<Exam>()
                .HasOne(e => e.SessionsExam)
                .WithMany()
                .HasForeignKey(e => e.SessionsExamId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            // Supervisor -> Room
            modelBuilder.Entity<Supervisor>()
                .HasOne(s => s.Room)
                .WithMany()
                .HasForeignKey(s => s.RoomId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            // SessionsExam -> Room
            modelBuilder.Entity<SessionsExam>()
                .HasOne(se => se.Room)
                .WithMany(r => r.SessionsExams)
                .HasForeignKey(se => se.IdRoom)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            // Additional configurations if necessary
        }
    }
}
