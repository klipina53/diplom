using Microsoft.AspNetCore.Identity;
using System;

namespace diplom.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public int? Weight { get; set; }
        public int? Height { get; set; }
        public string MembershipType { get; set; }
        public int? RemainingVisits { get; set; }
        public DateTime? MembershipEndDate { get; set; }
    }
}