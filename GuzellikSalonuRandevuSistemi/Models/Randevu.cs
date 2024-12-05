using System;

namespace GuzellikSalonuRandevuSistemi.Models
{
    namespace GuzellikSalonuRandevuSistemi.Models
    {
        public class Randevu
        {
            public int Id { get; set; }
            public DateTime RandevuTarihi { get; set; }
            public int KuaforId { get; set; }  // Foreign Key to Kuafor
            public Kuafor Kuafor { get; set; } // Navigation property to Kuafor

            public int IslemId { get; set; }  // Foreign Key to Islem
            public Islem Islem { get; set; } // Navigation property to Islem

            public string MusteriId { get; set; }  // Foreign Key to Musteri (Identity User ID)
            public Musteri Musteri { get; set; } // Navigation property to Musteri
            public bool OnaylandiMi { get; internal set; }
        }
    }
}