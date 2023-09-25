using Microsoft.EntityFrameworkCore;
using Online_Educator_Backend.Model;

namespace Online_Educator_Backend.Data
{
    using Microsoft.EntityFrameworkCore;
    using System.Reflection.Emit;

    public class UserContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }

        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "AuthorDb");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasMany(u => u.Courses)
                .WithMany(c => c.InstructorProfiles)
                .UsingEntity(j => j.ToTable("CourseInstructors"));


            base.OnModelCreating(modelBuilder);
        }
    }

}
