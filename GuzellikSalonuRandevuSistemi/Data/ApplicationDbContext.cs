using System;

namespace GuzellikSalonuRandevuSistemi.Data
{
    public class ApplicationDbContext
    {
        public object Kuaförler { get; internal set; }
        public object İşlemler { get; internal set; }
        public object GuzellikSalonu { get; internal set; }
        public object Randevular { get; internal set; }
        public object Kuaforler { get; internal set; }
        public object Islemler { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
