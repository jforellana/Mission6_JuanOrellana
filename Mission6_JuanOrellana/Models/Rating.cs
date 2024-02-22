using System.ComponentModel.DataAnnotations;

namespace Mission6_JuanOrellana.Models
{
    public class Rating
    {
        [Key]
        public int RatingId { get; set; }
        public string RatingName { get; set; }
    }
}
