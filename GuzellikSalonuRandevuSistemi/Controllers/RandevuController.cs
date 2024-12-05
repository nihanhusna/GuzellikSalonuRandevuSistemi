using GuzellikSalonuRandevuSistemi.Data;
using GuzellikSalonuRandevuSistemi.Models;
using GuzellikSalonuRandevuSistemi.Models.GuzellikSalonuRandevuSistemi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GuzellikSalonuRandevuSistemi.Controllers
{
    public class RandevuController : Controller
    {

        private readonly ApplicationDbContext _context;
        private object randevu;

        public RandevuController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult RandevuAl(int salonId)
        {
            var kuaforler = _context.Kuaforler.ToList();
            var ıslemler = _context.Islemler.ToList();
            ViewBag.Kuaforler = new SelectList(kuaforler, "Id", "Name");
            ViewBag.Islemler = new SelectList(ıslemler, "Id", "Name");
            return View();

            // Salon ve çalışanları listele
        }

        [HttpPost]
        public IActionResult RandevuAl(Randevu talep)
        {
            if (ModelState.IsValid)
            {
                // Randevu saati kontrolü
                var existingRandevu = _context.Randevular
                                                  .Any(a => a.EmployeeId == talep.KuaforId && a.DateTime == talep.RandevuTarihi);
                if (existingRandevu)
                {
                    ModelState.AddModelError("", "Bu saat diliminde çalışan zaten bir randevusu var.");
                    return View();
                }

                var appointment = new Randevu
                {
                    KuaforId = talep.KuaforId,
                    IslemId = talep.IslemId,
                    RandevuTarihi = talep.RandevuTarihi,
                    OnaylandiMi = false
                };

                _context.Randevular.Add(randevu);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(talep);


            // Randevu ekle ve uygunluk kontrolü
        }
    
    }
}
