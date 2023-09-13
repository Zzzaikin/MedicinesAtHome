using System.ComponentModel.DataAnnotations;

namespace Zzzaikin.MedicinesAtHome.Models
{
    public class User : BaseModel
    {
        [Required]
        public string Password { get; set; }

        public byte[] Image { get; set; }
    }
}
