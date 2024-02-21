using System.ComponentModel.DataAnnotations;

namespace Mission6_JuanOrellana.Models
{
    public class Rating
    {
        public Rating(object value1, object value2)
        {

        }

        [Key]
        public int RatingId { get; set; }
        public required string RatingName { get; set;}
    }
}
