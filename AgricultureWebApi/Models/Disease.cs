using System.ComponentModel.DataAnnotations;

namespace AgricultureWebApi.Models
{
    public class Disease
    {

        public int DiseaseId { get; set; }

        [MaxLength(50)]
        public string? Name { get; set; } 
        
        public byte AgricalturalTypeId { get; set; }
        public AgricalturalType? AgricalturalType { get; set; }

        public ICollection<AgricalturalDisease>? AgriCulturalDiseases { get; set; }    


        
    }
}
