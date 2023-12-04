namespace AgricultureWebApi.Models
{
    public class AgriculturalDisease
    {
        public  Guid Id { get; set; }

        public int AgriculturalProductId { get; set; }
        public AgriculturalProduct? AgriculturalProduct { get; set;}

        public String? Not { get; set; }


       public int DiseaseId { get; set; }
       public Disease? Disease { get; set; }

    }
}
