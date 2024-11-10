using Microsoft.AspNetCore.Mvc;

namespace GuzellikSalonuRandevuSistemi.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
