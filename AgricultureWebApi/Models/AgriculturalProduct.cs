using System.ComponentModel.DataAnnotations;

namespace AgricultureWebApi.Models
{
    public class AgriculturalProduct
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string? Name { get; set; }

        public byte AgricalturalTypeId { get; set; }
        public AgricalturalType? AgricalturalType { get; set; }

        public ICollection<AgricalturalDisease>? AgricalturalDiseases { get; set; }
    }
}
