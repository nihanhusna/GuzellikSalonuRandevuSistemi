namespace GuzellikSalonuRandevuSistemi.Models
{
    public class Randevu
    {
        public int RandevuId { get; set; }
        public DateTime RandevuTarihi { get; set; }
        public string IslemId { get; set; }
        public double Ucret { get; set; }
        public int KuaforId { get; set; }
        public Kuafor Kuafor { get; set; }
        public int MusteriId { get; set; }
        public Musteri Musteri { get; set; }

        public bool OnaylandiMi { get; set; }
    }
}
