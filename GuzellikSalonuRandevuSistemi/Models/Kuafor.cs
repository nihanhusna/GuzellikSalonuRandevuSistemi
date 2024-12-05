using GuzellikSalonuRandevuSistemi.Models.GuzellikSalonuRandevuSistemi.Models;
using System.Collections.Generic;

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

        public GuzellikSalonu GuzellikSalonu { get; set; } // Navigation Property

        public ICollection<Randevu> Randevular { get; set; } // İlgili Randevular
        public ICollection<CalismaSaatleri> CalismaSaatleri { get; set; } // Çalışma Saatleri

        public ICollection<Islem> Islemler { get; set; } // Yapabileceği İşlemler 
    }
}
