﻿using System.ComponentModel.DataAnnotations;

namespace MvcFromScratch.Models
{
    public class Category
    {
        [Required]
        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;

    }
}
