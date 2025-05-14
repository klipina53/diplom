using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace diplom.Models
{
    public class Trainer
    {
        public int Id { get; set; }

        [Display(Name = "ФИО")]
        public string FullName { get; set; }

        [Display(Name = "Образование")]
        public string Education { get; set; }

        [Display(Name = "Стаж работы")]
        public int Experience { get; set; }

        [Display(Name = "Цена за занятие")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PricePerSession { get; set; }

        [Display(Name = "Специализация")]
        public string Specialization { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Фото")]
        public string PhotoUrl { get; set; }
    }
}