namespace Online_Educator_Backend.Model
{
    public class Section
    {
        public List<Test>? Tests { get; set; }
        public List<Lecture>? Lectures { get; set; }
        public List<Exercises>? Exercises { get; set; }
        public List<Task>? Tasks { get; set; }
    }
}
