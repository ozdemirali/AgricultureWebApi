using AgricultureWebApi.Models;

namespace AgricultureWebApi.ViewModels
{
    public class ViewModelAgricalturalDisease
    {
        public Guid Id { get; set; }
        public int AgriculturalProductId { get; set; }
        public int DiseaseId { get; set; }
    }
}
