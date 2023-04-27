using Microsoft.AspNetCore.Mvc;
using MVCLogin.Models;
using System.Diagnostics;

namespace MVCLogin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet] // Login sayfasını çağırıyor
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost] // Login sayfasından gelen verileri alıyor. Öbür ekrandan post edilen durumda.
        public IActionResult Login(Login login)
        {

            if (login.UserID == "admin" && login.Password== "1234") 
            {
                ViewBag.Mesaj = "Tebrikler...Giriş başarılı.."; // Messagebox gibi bir kullanım
            }
            else
            {
                ViewBag.Mesaj = "Hatalı giriş...Lütfen tekrar deneyiniz";
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}