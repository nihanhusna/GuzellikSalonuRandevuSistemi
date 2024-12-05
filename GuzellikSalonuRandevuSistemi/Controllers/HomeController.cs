using GuzellikSalonuRandevuSistemi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using GuzellikSalonuRandevuSistemi.Models;
using GuzellikSalonuRandevuSistemi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GuzellikSalonuRandevuSistemi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Ana Sayfa
        public IActionResult Index()
        {
            var salon = _context.GuzellikSalonu.FirstOrDefault();
            return View(salon);
        }

        // Hata Sayfasý
        public IActionResult Error(string requestId)
        {
            var errorModel = new ErrorViewModel { RequestId = requestId };
            return View(errorModel);
        }
    }
}
