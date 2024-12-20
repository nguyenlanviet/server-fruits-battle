﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LidgrenServer.Models
{
    [Table("items")]
    public class ItemConsumableModel
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("name")]
        [StringLength(50)] // Updated to match schema constraints
        public string Name { get; set; } = null!;

        [Column("image_name")]
        [StringLength(50)] // Updated to match schema constraints
        public string ImageName { get; set; } = null!;

        [Required]
        [Column("effect_type")]
        [StringLength(50)] // Added based on schema
        public string EffectType { get; set; } = null!;

        [Required]
        [Column("value")]
        public int Value { get; set; } // Added based on schema

        [Required]
        [Column("duration")]
        public int Duration { get; set; } // Added based on schema

        [Required]
        [Column("target")]
        [StringLength(50)] // Added based on schema
        public string Target { get; set; } = null!;
    }
}
