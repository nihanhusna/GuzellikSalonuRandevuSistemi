using Microsoft.AspNetCore.Mvc;

namespace GuzellikSalonuRandevuSistemi.Controllers
{
    public class MusteriController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
