using Newtonsoft.Json.Linq;
using Online_Educator_Backend.Model.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Online_Educator_Backend.Model
{
    public class Course
    {
        public int Id { get; set; }
        public Language localization { get; set; }

        [Column("SomeListString")]
        private string SomeListString { get; set; }

        [NotMapped]
        [JsonIgnore]
        public List<string> SomeListStringJson
        {
            get => JsonSerializer.Deserialize<List<string>>(SomeListString);
            set => SomeListString = JsonSerializer.Serialize(value);
        }

        [Column("Requirements")]
        private string Requirements { get; set; }

        [NotMapped]
        [JsonIgnore]
        public List<string> RequirementsJson
        {
            get => JsonSerializer.Deserialize<List<string>>(Requirements);
            set => Requirements = JsonSerializer.Serialize<List<string>>(value);
        }

        [Column("Intended")]
        private string Intended { get; set; }

        [NotMapped]
        [JsonIgnore]
        public List<string> IntendedJson
        {
            get => JsonSerializer.Deserialize<List<string>>(Intended);
            set => Intended = JsonSerializer.Serialize(value);
        }


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


        [Column("Chapter")]
        private string Chapter { get; set; }

        [NotMapped]
        [JsonIgnore]
        public List<string> ChapterList
        {
            get => JsonSerializer.Deserialize<List<string>>(Chapter);
            set => Chapter = JsonSerializer.Serialize(value);
        }

        [Column("Curriculum")]
        private string Curriculum { get; set; }

        [NotMapped]
        [JsonIgnore]
        public List<Section> CurriculumJson
        {
            get => JsonSerializer.Deserialize<List<Section>>(Curriculum);
            set => Curriculum = JsonSerializer.Serialize(value);
        }
    }
}
