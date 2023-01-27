namespace AgricultureWebApi.Models
{
    public class Error
    {
        public Guid Id { get; set; }
        public string? Message { get; set; }
        public string? Place { get; set; }
        public DateTime Time { get; set; }
        
    }
}
