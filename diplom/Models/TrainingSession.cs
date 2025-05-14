using System;

namespace diplom.Models
{
    public class TrainingSession
    {
        public int Id { get; set; }
        public string UserId { get; set; } // Ссылка на пользователя
        public int? TrainerId { get; set; } // Ссылка на тренера (null для групповых)
        public DateTime SessionDate { get; set; }
        public int DurationMinutes { get; set; } // Длительность в минутах
        public bool IsGroupSession { get; set; } // true для групповых
        public string Notes { get; set; } // Дополнительные заметки

        // Навигационные свойства
        public Trainer Trainer { get; set; }
    }
}