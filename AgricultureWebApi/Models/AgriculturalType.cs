﻿using System.ComponentModel.DataAnnotations;

namespace AgricultureWebApi.Models
{
    public class AgriculturalType
    {
        public byte Id { get; set; }

        [MaxLength(50)]
        public string? Name { get; set; }  
        
        public ICollection<AgriculturalProduct>? AgriculturalProduct { get; set; }

    }
}
