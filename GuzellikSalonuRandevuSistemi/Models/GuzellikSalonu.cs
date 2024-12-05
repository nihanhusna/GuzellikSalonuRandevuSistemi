using System.Collections.Generic;

namespace GuzellikSalonuRandevuSistemi.Models
{
    public class GuzellikSalonu
    {

        public int GuzellikSalonuId { get; set; }
        public string GuzellikSalonuAdi { get; set; }
        public string Adres { get; set; } 
        public string Telefon { get; set; }
        public string CalismaSaatleri { get; set; }
        public ICollection<Islem> Islemler { get; set; }
        public ICollection<Kuafor> Kuaforler { get; set; }


    }
}
