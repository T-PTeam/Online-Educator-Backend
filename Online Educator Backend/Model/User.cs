using System.ComponentModel.DataAnnotations;

namespace Online_Educator_Backend.Model
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public List<Course> Courses { get; set; }
    }
}
