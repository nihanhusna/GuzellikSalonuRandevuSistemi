namespace GuzellikSalonuRandevuSistemi.Models
{
    public class Islem
    {

        public int IslemId { get; set; }
        public string IslemAdi { get; set; }
        public double Fiyat { get; set; }
        public TimeSpan Sure { get; set; } // İşlem süresi
        public int GuzellikSalonuId { get; set; }
        public GuzellikSalonu GuzellikSalonu { get; set; }

    }
}
