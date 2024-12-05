using System;

namespace GuzellikSalonuRandevuSistemi.Models
{
    public class CalismaSaatleri
    {
        public int Id { get; set; }
        public int KuaforId { get; set; }

        public DayOfWeek Gun { get; set; }         // Gün
        public TimeSpan Baslangic { get; set; }    // Başlangıç Saati
        public TimeSpan Bitis { get; set; }        // Bitiş Saati
        public Kuafor Kuafor { get; set; }         // Navigation Property
        public string? KuaforAdı { get; set; }
        public DateTime CalismaSaati { get; set; }
    }
}
