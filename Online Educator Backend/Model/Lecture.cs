using System.ComponentModel.DataAnnotations;

namespace Online_Educator_Backend.Model
{
    public class Lecture
    {
        
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
    }
}
