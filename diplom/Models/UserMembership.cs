using System;

namespace diplom.Models
{
    public class UserMembership
    {
        public int Id { get; set; }
        public string UserId { get; set; } // Ссылка на пользователя
        public int MembershipTypeId { get; set; } // Ссылка на тип абонемента
        public DateTime PurchaseDate { get; set; } = DateTime.Now;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? RemainingVisits { get; set; } // Осталось посещений
        public bool IsActive { get; set; } = true;

        // Навигационные свойства
        public MembershipType MembershipType { get; set; }
    }
}