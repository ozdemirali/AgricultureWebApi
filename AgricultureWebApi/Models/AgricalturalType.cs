using System.ComponentModel.DataAnnotations;

namespace AgricultureWebApi.Models
{
    public class AgricalturalType
    {
        public byte AgricalturalTypeId { get; set; }

        [MaxLength(50)]
        public string? Name { get; set; }  
        
        public ICollection<Disease>? Diseases { get; set; }
    }
}
