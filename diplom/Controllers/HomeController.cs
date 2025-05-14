using diplom.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace diplom.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;

        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Добро пожаловать в наш спортивный клуб!";
            return View();
        }

        public IActionResult Trainers()
        {
            var trainers = _db.Trainers.ToList();
            return View(trainers);
        }

        public IActionResult Products()
        {
            var products = _db.Products.ToList();
            return View(products);
        }

        public IActionResult Memberships() => View();

        public IActionResult Profile()
        {
            ViewBag.FullName = HttpContext.Session.GetString("UserEmail");
            return View();
        }
    }
}
