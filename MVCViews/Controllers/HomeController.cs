using Microsoft.AspNetCore.Mvc;
using MVCViews.Models;
using System.Diagnostics;

namespace MVCViews.Controllers
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

        [HttpGet] // HTTP Get metoduyla sayfayı getiriyorum.
        public IActionResult Personel()
        {
            return View();
        }

        [HttpPost] // HTTP Post Metoduyla sayfadan gelecek olan verileri alabiliyorum getiriyorum.
        public IActionResult Personel(Personel personel)
        {
            if (ModelState.IsValid) // Modelim geçerliyse
            {
                
                string personelBilgi = "";

                personelBilgi="Personelin bilgileri (Ad,Soyad,Yaş) : "+ personel.Ad + " " + personel.Soyad + " " + personel.Yas.ToString();

                ViewBag.Mesaj = personelBilgi;
            }

            return View(personel);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}