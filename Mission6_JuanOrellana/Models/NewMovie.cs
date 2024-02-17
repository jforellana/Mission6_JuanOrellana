using System.ComponentModel.DataAnnotations;

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
        public required string Rating { get; set; }
        public string? LentTo { get; set; }
        public string? Edited { get; set; }
        public string? Notes { get; set; }
    }
}
