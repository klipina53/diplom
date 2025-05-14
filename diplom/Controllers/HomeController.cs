using diplom.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

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

        private readonly UserManager<User> _userManager;

        public HomeController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Index");
            }

            return View(user);
        }
        [HttpPost]
        [HttpPost]
        public async Task<IActionResult> UpdateProfile(int? weight, int? height)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                user.Weight = weight;
                user.Height = height;
                await _userManager.UpdateAsync(user);
            }
            return RedirectToAction("Profile");
        }
    }
}
