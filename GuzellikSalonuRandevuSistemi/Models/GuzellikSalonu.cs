namespace GuzellikSalonuRandevuSistemi.Models
{
    public class GuzellikSalonu
    {

        public int GuzellikSalonuId { get; set; }
        public string GuzellikSalonuAdi { get; set; }
        public string Tip { get; set; } // (Kadın / Erkek)
        public string CalismaSaatleri { get; set; }
        public ICollection<Islem> Islemler { get; set; }
        public ICollection<Kuafor> Kuaforler { get; set; }


    }
}
