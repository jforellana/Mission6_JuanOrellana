﻿using System.ComponentModel.DataAnnotations;

namespace Mission6_JuanOrellana.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public required string CategoryName { get; set; }
    }
}
