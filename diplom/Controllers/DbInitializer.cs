using diplom.Models;
using System.Linq;

namespace diplom.Controllers
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Trainers.Any())
            {
                context.Trainers.AddRange(
                    new Trainer { FullName = "Иван Иванов", Education = "МГУ", Experience = 5, PricePerSession = 1000 },
                    new Trainer { FullName = "Петр Петров", Education = "РГУФК", Experience = 3, PricePerSession = 800 }
                );
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product { Name = "Гантели", Image = "/images/dumbbells.jpg", Price = 1500 },
                    new Product { Name = "Фитнес-резинки", Image = "/images/bands.jpg", Price = 500 }
                );
            }

            context.SaveChanges();
        }
    }

}
