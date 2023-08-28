using Microsoft.EntityFrameworkCore;
using Online_Educator_Backend.Model;

namespace Online_Educator_Backend.Data
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring
       (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "AuthorDb");
        }
    }
}
