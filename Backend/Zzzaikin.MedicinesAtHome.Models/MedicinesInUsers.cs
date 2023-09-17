using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zzzaikin.MedicinesAtHome.Models
{
    public class MedicinesInUsers : BaseModel
    {
        [Required]
        public Guid MedicineId  { get; set; }

        [Required]
        [ForeignKey("MedicineId")]
        public Medicine Medicine { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        [ForeignKey("UserId")]
        public User User{ get; set; }

        [Required]
        public DateTime GoodUntil { get; set; }

        public byte[] UserPhotoOfMedicine { get; set; }
    }
}
