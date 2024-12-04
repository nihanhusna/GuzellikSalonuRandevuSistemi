namespace GuzellikSalonuRandevuSistemi.Models
{
    public class Kuafor
    {
        public int KuaforId { get; set; }
        public string Adı { get; set; }
        public string Soyadı { get; set; }
        public string UzmanlıkAlanı { get; set; }
        public bool Durum { get; set; } // (Müsait / Müsait Değil)
        public int GuzellikSalonuId { get; set; }
        
        public ICollection<Islem> Islemler { get; set; } // Yapabileceği İşlemler 
        public ICollection <Randevu> Randevular { get; set; }
        

    }
}
