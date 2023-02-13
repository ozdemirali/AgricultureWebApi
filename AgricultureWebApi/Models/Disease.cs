using System.ComponentModel.DataAnnotations;

namespace AgricultureWebApi.Models
{
    public class Disease
    {

        public int Id { get; set; }

        [MaxLength(50)]
        public string? Name { get; set; } 
        
        public byte AgricalturalTypeId { get; set; }
     

        public ICollection<AgriculturalDisease>? AgricalturalDisease { get; set; }

        
    }
}
