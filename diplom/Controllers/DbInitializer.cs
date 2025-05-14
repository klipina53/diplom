using diplom.Models;
using System.Linq;

namespace diplom
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Trainers.Any())
            {
                context.Trainers.AddRange(
                    new Trainer
                    {
                        FullName = "Иван Иванов",
                        Education = "МГУ",
                        Experience = 5,
                        PricePerSession = 1000,
                        Specialization = "Фитнес",
                        Description = "Опытный тренер по фитнесу",
                        PhotoUrl = "/images/trainer1.jpg"
                    },
                    new Trainer
                    {
                        FullName = "Петр Петров",
                        Education = "РГУФК",
                        Experience = 3,
                        PricePerSession = 800,
                        Specialization = "Йога",
                        Description = "Сертифицированный инструктор по йоге",
                        PhotoUrl = "/images/trainer2.jpg"
                    }
                );
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Гантели",
                        Image = "/images/dumbbells.jpg",
                        Price = 1500
                    },
                    new Product
                    {
                        Name = "Фитнес-резинки",
                        Image = "/images/bands.jpg",
                        Price = 500
                    }
                );
            }

            context.SaveChanges();
        }
    }
}