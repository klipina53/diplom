using Microsoft.AspNetCore.Identity;
using System;

namespace diplom.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public int? Weight { get; set; }        // Вес в кг
        public int? Height { get; set; }        // Рост в см
        public string MembershipType { get; set; } // Тип абонемента
        public int? RemainingVisits { get; set; }  // Осталось посещений
        public DateTime? MembershipEndDate { get; set; } // Дата окончания абонемента
    }
}