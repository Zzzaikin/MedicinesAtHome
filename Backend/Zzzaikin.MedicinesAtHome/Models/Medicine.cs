using System.ComponentModel.DataAnnotations;

namespace Zzzaikin.MedicinesAtHome.Models
{
    public class Medicine : BaseModel
    {
        [Required]
        public DateTime GoodUntil { get; set; }

        public ushort Volume { get; set; }

        public byte[] Image { get; set; }
    }
}
