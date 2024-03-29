﻿using AgricultureWebApi.Models;

namespace AgricultureWebApi.ViewModels
{
    public class ViewModelAgriculturalDisease
    {
        public Guid Id { get; set; }
        public int AgriculturalProductId { get; set; }
        public int DiseaseId { get; set; }
        public String? Not { get; set; }
        public String? ImageName { get; set; }
    }
}
