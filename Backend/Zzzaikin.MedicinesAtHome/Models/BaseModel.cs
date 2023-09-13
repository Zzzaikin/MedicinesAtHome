using System.ComponentModel.DataAnnotations;

namespace Zzzaikin.MedicinesAtHome.Models
{
    public abstract class BaseModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public Guid CreatedBy { get; set; }
    }
}
