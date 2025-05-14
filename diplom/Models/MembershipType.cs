using System.ComponentModel.DataAnnotations.Schema;

namespace diplom.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public string TypeName { get; set; } // individual, grouped, without_trainer
        public string Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public int DurationDays { get; set; } // Длительность абонемента в днях
        public int? VisitsCount { get; set; } // Количество посещений (null для безлимитных)
        public bool IsPersonalTraining { get; set; } // true для индивидуальных тренировок
    }
}