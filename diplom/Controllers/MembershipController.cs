using diplom.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace diplom.Controllers
{
    [Authorize]
    public class MembershipController : Controller
    {
        private readonly AppDbContext _db;

        public MembershipController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Purchase(string type)
        {
            var membership = _db.MembershipTypes.FirstOrDefault(m => m.TypeName == type);
            if (membership == null)
            {
                return NotFound();
            }

            return View(membership);
        }

        [HttpPost]
        public IActionResult Purchase(int membershipTypeId)
        {
            var membership = _db.MembershipTypes.Find(membershipTypeId);
            if (membership == null)
            {
                return NotFound();
            }

            var user = _db.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            if (user == null)
            {
                return NotFound();
            }

            var userMembership = new UserMembership
            {
                UserId = user.Id,
                MembershipTypeId = membership.Id,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(membership.DurationDays),
                RemainingVisits = membership.VisitsCount,
                IsActive = true
            };

            _db.UserMemberships.Add(userMembership);
            _db.SaveChanges();

            // Обновляем информацию о пользователе
            user.MembershipType = membership.TypeName;
            user.RemainingVisits = membership.VisitsCount;
            user.MembershipEndDate = userMembership.EndDate;
            _db.SaveChanges();

            return RedirectToAction("Profile", "Home");
        }
    }
}