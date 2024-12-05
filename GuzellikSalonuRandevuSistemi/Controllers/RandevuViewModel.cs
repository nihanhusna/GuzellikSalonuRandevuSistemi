using GuzellikSalonuRandevuSistemi.Models;
using System;
using System.Collections.Generic;

namespace GuzellikSalonuRandevuSistemi.Controllers
{
    public class RandevuViewModel
    {
        public int KuaforId { get; internal set; }
        public List<Kuafor> Kuaforler { get; internal set; }
        public List<Islem> Islemler { get; internal set; }
        public int IslemId { get; internal set; }
        public DateTime RandevuTarihi { get; internal set; }
    }
}