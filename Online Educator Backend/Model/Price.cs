using Online_Educator_Backend.Model.Enums;

namespace Online_Educator_Backend.Model
{
    public class Price
    {
        public required Currency Currency { get; set; }
        public required decimal PriceCourse { get; set; }
    }
}
