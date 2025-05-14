using diplom.Models;
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

        public IActionResult Memberships()
        {
            var memberships = _db.MembershipTypes.ToList();
            return View(memberships);
        }

        public IActionResult Profile()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            var user = _db.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            return View(user);
        }
    }
}