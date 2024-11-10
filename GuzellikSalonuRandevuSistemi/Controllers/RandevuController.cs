using GuzellikSalonuRandevuSistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace GuzellikSalonuRandevuSistemi.Controllers
{
    public class RandevuController : Controller
    {

        private readonly ApplicationDbContext _context;

        public RandevuController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult RandevuAl(int salonId)
        {
            // Salon ve çalışanları listele
        }

        [HttpPost]
        public IActionResult RandevuAl(Randevu model)
        {
            // Randevu ekle ve uygunluk kontrolü
        }
    
    }
}
