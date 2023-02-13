using AgricultureWebApi.Models;

namespace AgricultureWebApi.ViewModels
{
    public class ViewModelAgriculturalDisease
    {
        public Guid Id { get; set; }
        public int AgriculturalProductId { get; set; }
        public int DiseaseId { get; set; }
    }
}
