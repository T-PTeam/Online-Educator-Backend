using Online_Educator_Backend.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace Online_Educator_Backend.Model
{
    public class Price
    {
        
        public int Id { get; set; }
        public required Currency Currency { get; set; }
        public required decimal PriceCourse { get; set; }
    }
}
