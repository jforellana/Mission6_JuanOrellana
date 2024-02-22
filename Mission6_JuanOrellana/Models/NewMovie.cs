using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6_JuanOrellana.Models
{
    public class NewMovie
    {
        [Key]
        public int MovieID { get; set; }
        public required string Category { get; set; }
        public required string Title { get; set; }
        public required int Year { get; set; }
        public required string Director { get; set; }

        [ForeignKey("RatingId")]
        public required int RatingId { get; set; }
        public required Rating Rating { get; set; }
        public string? LentTo { get; set; }
        public string? Edited { get; set; }
        public string? Notes { get; set; }
    }
}
