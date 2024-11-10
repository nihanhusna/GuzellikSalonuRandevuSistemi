namespace GuzellikSalonuRandevuSistemi.Models
{
    public class Musteri
    {
        public int MusteriId { get; set; }
        public string MusteriAdı { get; set; }
        
        public string Sifre { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        public bool IsAdmin { get; set; }

    }
}
