﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6_JuanOrellana.Models
{
    public class NewMovie
    {
        [Key]
        public int MovieID { get; set; }
        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public required string Title { get; set; }
        public required int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        public required bool Edited { get; set; }
        public string? LentTo { get; set; }
        public required bool CopiedToPlex { get; set; }
        public string? Notes { get; set; }
    }
}
