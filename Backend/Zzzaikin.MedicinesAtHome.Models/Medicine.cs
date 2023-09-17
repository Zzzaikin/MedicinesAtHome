namespace Zzzaikin.MedicinesAtHome.Models
{
    public class Medicine : BaseModel 
    {
        public byte[] Image { get; set; }    

        public string ShortDescription { get; set; }

        public int ItemsCount { get; set; }
    }
}
