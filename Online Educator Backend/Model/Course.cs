using Online_Educator_Backend.Model.Enums;

namespace Online_Educator_Backend.Model
{
    public class Course
    {
        public Language localization { get; set; }
        public required List<string> Topics { get; set; }
        public required List<string> Requirements { get; set; }
        public required List<string> Intended { get; set; }
        public required string Title { get; set; }
        public required string Subtitle { get; set; }
        public required string Description { get; set; }
        public required string Category { get; set; } 
        public required string Level { get; set; }
        public required string Subcategory { get; set; }
        public required string MainSubject { get; set; }
        public required string Image { get; set; }
        public required string PromotionalVideo { get; set; }
        public required List<User> InstructorProfiles { get; set; }
        public required Price Price { get; set; }
        public string? Greetings { get; set; }
        public string? Congratulation { get; set; }
        public required List<string> Chapter { get; set; }
        public required List<Section> Curriculum { get; set; }
    }
}
