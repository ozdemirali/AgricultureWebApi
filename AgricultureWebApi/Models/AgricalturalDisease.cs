namespace AgricultureWebApi.Models
{
    public class AgricalturalDisease
    {
        public  Guid Id { get; set; }

        public int AgriculturalProductId { get; set; }
        public AgriculturalProduct? AgriculturalProduct { get; set;}


       public int DiseaseId { get; set; }
       public Disease? Disease { get; set; }

    }
}
