using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Online_Educator_Backend.Model
{
    public class Section
    {

        public int Id { get; set; }

        [Column("Tests")]
        private string Tests { get; set; }

        [NotMapped]
        [JsonIgnore]
        public List<Test>? TestsJson
        {
            get => JsonSerializer.Deserialize<List<Test>>(Tests);
            set => Tests = JsonSerializer.Serialize(value);
        }

        [Column("Lectures")]
        private string Lectures { get; set; }

        [NotMapped]
        [JsonIgnore]
        public List<Lecture>? LecturesJson
        {
            get => JsonSerializer.Deserialize<List<Lecture>>(Lectures);
            set => Lectures = JsonSerializer.Serialize(value);
        }

        [Column("Exercises")]
        private string Exercises { get; set; }

        [NotMapped]
        [JsonIgnore]
        public List<Exercises>? ExercisesJson
        {
            get => JsonSerializer.Deserialize<List<Exercises>>(Exercises);
            set => Exercises = JsonSerializer.Serialize(value);
        }

        [Column("Tasks")]
        private string Tasks { get; set; }

        [NotMapped]
        [JsonIgnore]
        public List<Task>? TasksJson
        {
            get => JsonSerializer.Deserialize<List<Task>>(Tasks);
            set => Tasks = JsonSerializer.Serialize(value);
        }

    }
}
