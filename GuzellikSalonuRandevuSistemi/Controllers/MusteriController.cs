using GuzellikSalonuRandevuSistemi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using GuzellikSalonuRandevuSistemi.Data;

namespace GuzellikSalonuRandevuSistemi.Controllers
{
    [Authorize]
    public class MüşteriController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MüşteriController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Kuaförleri Görüntüleme
        public IActionResult Kuaforler()
        {
            var kuaförler = _context.Kuaförler.Include(k => k.UzmanlıkAlanı).ToList();
            return View(kuaförler);
        }

        // Kuaför Seçme
        public IActionResult KuaförSec(int id)
        {
            var kuaför = _context.Kuaförler.Include(k => k.UzmanlıkAlanı).FirstOrDefault(k => k.Id == id);
            return View(kuaför);
        }

        // Randevu Alma
        public IActionResult RandevuAl(int kuaforId)
        {
            var kuaför = _context.Kuaförler.Include(k => k.UzmanlıkAlanı).FirstOrDefault(k => k.Id == kuaförId);
            var işlemler = _context.İşlemler.ToList();
            var model = new RandevuViewModel
            {
                KuaforId = kuaforId,
                Kuaförler = new List<Kuafor> { kuaför },
                İşlemler = işlemler
            };
            return View(model);
        }

        // Randevu Onayı
        [HttpPost]
        public IActionResult RandevuOnay(RandevuViewModel model)
        {
            if (ModelState.IsValid)
            {
                var randevu = new Randevu
                {
                    KuaförId = model.KuaforId,
                    İşlemId = model.IslemId,
                    MüşteriId = User.Identity.Name,
                    RandevuTarihi = model.RandevuTarihi
                };

                _context.Randevular.Add(randevu);
                _context.SaveChanges();
                return RedirectToAction("Randevularım");
            }

            return View(model);
        }

        // Müşteri Randevularını Görüntüleme
        public IActionResult Randevularım()
        {
            var randevular = _context.Randevular.Where(r => r.MüşteriId == User.Identity.Name).ToList();
            return View(randevular);
        }
    }

    internal class RandevuViewModel
    {
        public int KuaforId { get; set; }
        public List<Kuafor> Kuaförler { get; set; }
        public object İşlemler { get; set; }
        public object IslemId { get; internal set; }
        public object RandevuTarihi { get; internal set; }
    }
}
