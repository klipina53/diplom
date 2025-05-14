// Controllers/TrainersController.cs
using Microsoft.AspNetCore.Mvc;
using diplom.Models;
using System.Collections.Generic;

namespace diplom.Controllers
{
    public class TrainersController : Controller
    {
        // Временные данные для примера
        private readonly List<Trainer> _trainers = new List<Trainer>
        {
            new Trainer {
                Id = 1,
                FullName = "Иванов Иван Иванович",
                Specialization = "Фитнес-тренер",
                Education = "Высшее спортивное образование",
                Experience = 5,
                PricePerSession = 1500,
                Description = "Опытный тренер с индивидуальным подходом к каждому клиенту.",
                PhotoUrl = "/images/trainer1.jpg"
            },
            // Добавьте других тренеров
        };

        public IActionResult Index()
        {
            return View(_trainers);
        }

        public IActionResult Details(int id)
        {
            var trainer = _trainers.Find(t => t.Id == id);
            if (trainer == null)
            {
                return NotFound();
            }
            return View(trainer);
        }
    }
}
