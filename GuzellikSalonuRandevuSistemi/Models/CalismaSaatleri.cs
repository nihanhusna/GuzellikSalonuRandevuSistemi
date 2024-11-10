namespace GuzellikSalonuRandevuSistemi.Models
{
    public class CalismaSaatleri
    {
        public int Id { get; set; }
        public int KuaforId { get; set; }
        public string? KuaforAdı { get; set; }
        public DateTime CalismaSaati { get; set; }
    }
}
