namespace AgricultureWebApi.Models
{
    public class AgricalturalDisease
    {
        public  Guid Id { get; set; }

        public int AgcicultureProductId { get; set; }

        public AgriculturalProduct? AgciculturalProduct { get; set;}


        public int DiseaseId { get; set; }
        public Disease? Disease { get; set;}

    }
}
